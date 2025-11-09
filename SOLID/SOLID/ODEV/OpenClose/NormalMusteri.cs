using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.OpenClose
{ 
    public class NormalMusteri : IMusteri
    {
        public double IndirimliFiyat(double price)
        {
            return price;
        }
    }
}
