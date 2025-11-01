using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Machine
{
    public class WashingMachine : IElectricUsing, IWoshing
    {
        public void ElekricUs()
        {
            Console.WriteLine("Washining Machine Elecric Using");
        }

        public void Wosh()
        {
            Console.WriteLine("Camaşır makınası yıkar");
        }
    }
}
