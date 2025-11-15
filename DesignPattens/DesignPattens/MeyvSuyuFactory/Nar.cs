using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory
{
    public class Nar : IMeyve
    {
        public void Uret()
        {
            Console.WriteLine("Nar suyu hazır.");
        }
    }
}
