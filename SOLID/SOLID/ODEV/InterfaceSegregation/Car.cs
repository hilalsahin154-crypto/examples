using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.InterfaceSegregation
{

    public class Car : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car Driving");
        }
    }
}
