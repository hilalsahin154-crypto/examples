using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.Dependencyllnversion
{
    public class DeviceService : IDevicesService
    {
        public void SendOn()
        {
            Console.WriteLine("Işık açıldı");
        }
        public void SendOff()
        {
            Console.WriteLine("Işık kapandı");
        }
        public void SendUp()
        {
            Console.WriteLine("Işık artırıldı");
        }
        public void SendDown()
        {
            Console.WriteLine("Isık azaltıldı");
        }
    }
}
