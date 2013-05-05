using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Json
{
    using AppLogger;
    public class Deserializer
    {
        public T parseFromFile<T>(string filename)
        {

            var logger = new Logger("Parser");
            logger.Write(MessageType.Debug, "Parsing " + filename);
            var stringreaderobj = new System.IO.StreamReader(filename);
            var rdr = new JsonTextReader(stringreaderobj);
            JsonSerializer serialiser = new JsonSerializer();
            return (T)serialiser.Deserialize(rdr, typeof(T));


        }

    }
}
