using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class OgrenciIsler
    {
        //TODO:Parametresiz motod
        public void SelamVer()
        {
            Console.WriteLine("Merhaba ögrencim");
        }
        //TODO:Paramtreli metod
        public void SelamVer(string ogrenci)
        {
            Console.WriteLine($"Merhaba {ogrenci}");
        }
        //TODO:Donuş tipi olan parametresiz metod
        public int YasHesapla()
        {
            return DateTime.Now.Year - 2001;
        }
        //TODO:Donuş tipi olan parametreli motod
        public int YasHesapla(int dogumTarihi)
        {
            return DateTime.Now.Year - dogumTarihi;
        }
    }
}
