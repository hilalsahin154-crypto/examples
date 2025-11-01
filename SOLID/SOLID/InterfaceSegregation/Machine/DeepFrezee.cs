using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Machine
{
    public class DeepFrezee : IElectricUsing, IFreezing

    {
        public void ElekricUs()
        {
            Console.WriteLine("DeepFrezee Elecric Using");
        }

        public void Freez()
        {
            Console.WriteLine("DeepFrezee Freez");
        }
    }
}
