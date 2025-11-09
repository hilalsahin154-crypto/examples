using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.InterfaceSegregation
{
    public class Airplane : IDrive, IFly
    {
        public void Drive()
        {
            Console.WriteLine("Airplane Driving");
        }

        public void Fly()
        {
            Console.WriteLine("Airplane Flying");
        }
    }
}
