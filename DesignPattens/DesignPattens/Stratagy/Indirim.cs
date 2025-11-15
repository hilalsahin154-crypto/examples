using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Stratagy
{
    public class Yuzde10 : IIndirim
    {
        public double Hesapla(double hesapla)
        {
            return hesapla * 0.9;
        }

    }
    public class Yuzde20 : IIndirim
    {
        public double Hesapla(double hesapla)
        {
            return hesapla * 0.8;
        }
    }
}

