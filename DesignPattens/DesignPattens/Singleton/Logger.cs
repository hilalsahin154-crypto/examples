using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Singleton
{
    public class Logger
    {
        private static Logger instance;
        private Logger() { }
        public static Logger GetLogger()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message) { Console.WriteLine($"Log--->{message}"); }
    }
}
