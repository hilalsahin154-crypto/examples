using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory
{
    public class Portakal : IMeyve
    {
        public void Uret()
        {
            Console.WriteLine("Portakal suyu hazır.");
        }
    }
}
