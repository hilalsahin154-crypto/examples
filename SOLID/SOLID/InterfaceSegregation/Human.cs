using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class Human : IWorking, ITalking
    {
        public void Talk()
        {
            Console.WriteLine("Humon Talking");
        }

        public void Work()
        {
            Console.WriteLine("Humon Working");
        }
    }
}
