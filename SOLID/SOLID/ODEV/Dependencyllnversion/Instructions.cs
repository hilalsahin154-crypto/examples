using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.Dependencyllnversion
{
    public class Instructions
    {
        private IDevicesService devicesService;
        public Instructions(IDevicesService devicesService)
        {
            this.devicesService = devicesService;
        }
        public void Off()
        {
            devicesService.SendOff();
        }
    }
}
