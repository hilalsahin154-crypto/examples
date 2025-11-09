using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.LiskovSubstitution
{
    public class Fruit 
    {
        public virtual void Taste()
        {
            Console.WriteLine("Meyve tatlıdır.");
        }
    }
}
