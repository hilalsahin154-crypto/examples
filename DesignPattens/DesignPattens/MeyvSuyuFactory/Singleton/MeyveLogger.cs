using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory.Singleton
{
    public class MeyveLogger
    {
        private static MeyveLogger instance;
        private MeyveLogger() { }
        public static MeyveLogger GetMeyveLogger()
        {
            if (instance == null)
            {
                instance = new MeyveLogger();
            }
            return instance;
        }
        public void Log(string message) { Console.WriteLine($"Log--->{message}"); }
    }
}

