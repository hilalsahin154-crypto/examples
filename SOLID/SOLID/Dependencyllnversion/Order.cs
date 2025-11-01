using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependencyllnversion
{
    public class Order
    {
        private IMassageService massageService;
        public Order(IMassageService massageService)
        {
            this.massageService = massageService;
        }
        public void Onayla()
        {
            massageService.Send5();
        }

    }
}
