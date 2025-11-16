using DesignPattens.MeyvSuyuFactory.Singleton;
using DesignPattens.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory
{
    public class Elma : IMeyve
    {
        public void Uret()
        {
            Console.WriteLine("Elma suyu hazır.");
        }
    }
}
