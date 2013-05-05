using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppLogger;

namespace consoleApp
{
    using Json;
    using Model;
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger("Main");
            var JSON_FILENAME = "configuration.json";

            try
            {

                var config = new Json.Deserializer().parseFromFile<GoogleOAuth2Config>(JSON_FILENAME);
                logger.Write(0, config.ToString());

                var token = new GoogleService.Authenticator().getAuthenticationToken(config);

                logger.Write(0, token);

                 string metrics = "ga:totalEvents";
                string dimensions =
                "ga:date,ga:hostname,ga:pageTitle,ga:dimension1,ga:eventAction,ga:eventCategory,ga:eventLabel";


                GoogleService.Fetch.getQueryAnalyticsResult(token, metrics, dimensions);


                
            }
            catch (Exception exc)
            {
                logger.Write((MessageType)4, exc.Message);

            }


            
        }
    }
}
