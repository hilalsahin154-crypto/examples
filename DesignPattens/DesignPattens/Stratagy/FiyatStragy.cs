using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Stratagy
{
    public class FiyatStragy
    {
        public IIndirim strateji;
        public double Hesapla(double tutar) => strateji.Hesapla(tutar);

    }
}
