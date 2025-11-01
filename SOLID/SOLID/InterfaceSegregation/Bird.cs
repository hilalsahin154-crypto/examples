using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class Bird : IWorking, ITalking, IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Bird Flying");
        }

        public void Talk()
        {
            Console.WriteLine("Bird Talking");
        }

        public void Work()
        {
            Console.WriteLine("Bird Working");
        }
    }
}
