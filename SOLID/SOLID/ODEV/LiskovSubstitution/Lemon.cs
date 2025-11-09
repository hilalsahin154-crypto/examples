using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.LiskovSubstitution
{
    public class Lemon : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Limon meyvedir ama tadı ekşidir.");
        }
    }
}
