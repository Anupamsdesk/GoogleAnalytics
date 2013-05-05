using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Registry
{
    using Microsoft.Win32;
    public class Helper
    {

        static string REGISTRY_KEY_PREFIX = @"SOFTWARE\CrimsonU\CB\";
        
        public enum SubKey{TokenName, ExpireTime};
        static string[] SubKeyNames = { "OAuthToken", "ExpireTime"};

        string accessKey;
        string keypath;

        static string getSubKeyNameFor(SubKey key) {
            return SubKeyNames[(int)key];
        }


        public Helper(string key)
        {
            if (! String.IsNullOrEmpty(key) &&
                ! String.IsNullOrWhiteSpace(key)){
                this.accessKey=key;
                keypath = REGISTRY_KEY_PREFIX + key;
            }
            else throw new ArgumentNullException("apiAccessKey value was invalid!");
        }


        public string getExpireTime() {
            
            try
            {
                var etime = Registry.LocalMachine.OpenSubKey(keypath)
                               .GetValue(getSubKeyNameFor(SubKey.ExpireTime))
                               .ToString();
                return etime;

            }
            catch (Exception e) { //KEY WAS NOT PRESENT
                var key = Registry.LocalMachine.CreateSubKey(keypath);
                key.SetValue(getSubKeyNameFor(SubKey.TokenName), "");
                key.Close();
            }
            return string.Empty;
        }

        public string getAccessToken() {
            try
            {
                var atoken = Registry.LocalMachine.OpenSubKey(keypath)
                               .GetValue(getSubKeyNameFor(SubKey.TokenName))
                               .ToString();
                return atoken;

            }
            catch (Exception e)
            { //KEY WAS NOT PRESENT
                var key = Registry.LocalMachine.CreateSubKey(keypath);
                key.SetValue(getSubKeyNameFor(SubKey.ExpireTime),
                    DateTime.UtcNow.AddSeconds(3500).ToString("MM/dd/yyyy HH:mm:ss")
                    );
                key.Close();
            }
            return string.Empty;
        
        
        }

        public void putValue(SubKey keyname, string value) {

            RegistryKey key;
            key = Registry.LocalMachine.CreateSubKey(keypath);
            key.SetValue(getSubKeyNameFor(keyname), value);
            key.Close();
            
        }

        public void putInterval(SubKey keyname, int interval) {
            RegistryKey key;
            key = Registry.LocalMachine.CreateSubKey(keypath);
            key.SetValue(getSubKeyNameFor(keyname), DateTime.UtcNow.AddSeconds(interval).ToString("MM/dd/yyyy HH:mm:ss"));
            key.Close();
        }
    }
}
