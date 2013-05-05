using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleService
{
    using Model;
    using System.Security.Cryptography.X509Certificates;
    using Newtonsoft.Json;
    using System.Security.Cryptography;
    using System.Net.Http;
    using AppLogger;
    using Windows.Registry;

    public class Authenticator
    {

        static string SCOPE = "https://www.googleapis.com/auth/analytics.readonly";
        static string AUDIENCE = "https://accounts.google.com/o/oauth2/token";
        static string HEADER_TYPE = "JWT";
        static string HEADER_ALGO = "RS256";
        static string FALLBACK_EXPIRY_DATE = "01/01/2000";


        public string getAuthenticationToken(GoogleOAuth2Config config) {
            var logger = new Logger("GoogleService.Authenticator");
            var registry = new Windows.Registry.Helper(config.ApiAccessKey);

            var expiryTime = registry.getExpireTime();
            if (String.IsNullOrEmpty(expiryTime) || expiryTime.Length < 4)
            {
                expiryTime = FALLBACK_EXPIRY_DATE;
            }
            var ExpireDateTime = Convert.ToDateTime(expiryTime);
            var ExpireTimeNow = DateTime.UtcNow;
            TimeSpan span = ExpireDateTime - ExpireTimeNow;
            double iExpireLeft = span.TotalSeconds;


            logger.Write(0, "Expire time left (sec): " + iExpireLeft);

            if (iExpireLeft < 60) {
                logger.Write(0, "Requesting authentication token from server...");
                var tokenObject = requestAuthenticationToken(config);

                if (tokenObject.access_token == null)
                    throw new NullReferenceException("access_token is null");


                registry.putValue(Helper.SubKey.TokenName, tokenObject.access_token);
                registry.putInterval(Helper.SubKey.ExpireTime, tokenObject.expires_in);
                logger.Write(0, "Token Received successfully");
            }
            
            
            string accessToken = registry.getAccessToken();
            return accessToken;
        }


        public Token requestAuthenticationToken(GoogleOAuth2Config config) {
            var certificate = new X509Certificate2(
               config.DirectoryName + "\\" + config.PrivateKeyFilename,
               config.CertificatePassword);


            var header = new { typ = HEADER_TYPE, alg = HEADER_ALGO };
            // claimset
            var times = GetExpiryAndIssueDate();
            var claimset = new
            {
                iss = config.ServiceAccountEmail,
                scope = SCOPE,
                aud = AUDIENCE,
                iat = times[0],
                exp = times[1],
            };


            // encoded header
            var headerSerialized = JsonConvert.SerializeObject(header);
            var headerBytes = Encoding.UTF8.GetBytes(headerSerialized);
            var headerEncoded = Base64UrlEncode(headerBytes);

            // encoded claimset
            var claimsetSerialized = JsonConvert.SerializeObject(claimset);
            var claimsetBytes = Encoding.UTF8.GetBytes(claimsetSerialized);
            var claimsetEncoded = Base64UrlEncode(claimsetBytes);

            // input
            var input = headerEncoded + "." + claimsetEncoded;
            var inputBytes = Encoding.UTF8.GetBytes(input);


            // signature
            var rsa = certificate.PrivateKey as RSACryptoServiceProvider;
            var cspParam = new CspParameters
            {
                KeyContainerName = rsa.CspKeyContainerInfo.KeyContainerName,
                KeyNumber = rsa.CspKeyContainerInfo.KeyNumber == KeyNumber.Exchange ? 1 : 2
            };
            var aescsp = new RSACryptoServiceProvider(cspParam) { PersistKeyInCsp = false };
            var signatureBytes = aescsp.SignData(inputBytes, "SHA256");
            var signatureEncoded = Base64UrlEncode(signatureBytes);

            // jwt
            var jwt = headerEncoded + "." + claimsetEncoded + "." + signatureEncoded;

            var client = new HttpClient();
            var uri = "https://accounts.google.com/o/oauth2/token";
            var post = new Dictionary<string, string>
                    {
                        {"assertion", jwt},
                        {"grant_type", "urn:ietf:params:oauth:grant-type:jwt-bearer"}
                    };
            var content = new FormUrlEncodedContent(post);
            //Console.WriteLine(content.ReadAsStringAsync().Result);
            var result = client.PostAsync(uri, content).Result;

            Token tokenObject = JsonConvert.DeserializeObject<Token>
                (result.Content.ReadAsStringAsync().Result);

            return tokenObject;


        }


        


        public static int[] GetExpiryAndIssueDate()
        {
            var utc0 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var issueTime = DateTime.UtcNow;

            var iat = (int)issueTime.Subtract(utc0).TotalSeconds;
            var exp = (int)issueTime.AddMinutes(55).Subtract(utc0).TotalSeconds;

            return new[] { iat, exp };
        }

        public static string Base64UrlEncode(byte[] input)
        {
            var output = Convert.ToBase64String(input);
            output = output.Split('=')[0]; // Remove any trailing '='s
            output = output.Replace('+', '-'); // 62nd char of encoding
            output = output.Replace('/', '_'); // 63rd char of encoding
            return output;
        }


    }
}
