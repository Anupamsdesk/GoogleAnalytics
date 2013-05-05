using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using log4net.Config;

namespace AppLogger
{
    //private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
    
    public enum MessageType {Debug,Info,Warning,Error,Fatal};
    
    public class Logger
    {
        private ILog logger;
        //private static console
        public Logger(string parent){
            logger = LogManager.GetLogger(parent);
        }
        static Logger()
        {
            
            
        }


        public void Write(int type, object msg)
        {
            this.Write((MessageType)type, msg);
        }
        public void Write(MessageType type, object msg){
          
            switch (type)
            {
                case MessageType.Debug:
                    logger.Debug(msg);
                    break;
                case MessageType.Error:
                    logger.Error(msg);
                    break;
                case MessageType.Fatal:
                    logger.Fatal(msg);
                    break;
                case MessageType.Info:
                    logger.Info(msg);
                    break;
                case MessageType.Warning:
                    logger.Warn(msg);
                    break;
                default:
                    logger.Info(msg);
                    break;

            }

        }
    }
}
