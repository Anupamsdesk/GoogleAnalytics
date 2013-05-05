using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GoogleOAuth2Config
    {
        public string CertificatePassword { get; set; }
        public string ServiceAccountEmail { get; set; }
        public string ApiAccessKey { get; set; }
        public string PrivateKeyFilename { get; set; }
        public string DirectoryName { get; set; }



        public override string ToString()
        {
            return String.Format("CertificatePassword: {0}, Service Account Email: {1}, ApiAccessKey: {2}, PrivateKeyFilename: {3}, DirectoryName: {4} ",
                CertificatePassword, ServiceAccountEmail, ApiAccessKey, PrivateKeyFilename, DirectoryName);
               
        }
    }
}
