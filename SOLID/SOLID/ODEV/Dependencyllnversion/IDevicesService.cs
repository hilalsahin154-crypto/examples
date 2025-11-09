using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.Dependencyllnversion
{
    public interface IDevicesService
    {
        void SendOn();
        void SendOff();
        void SendUp();
        void SendDown();
    }
}
