using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods.opp
{
    internal class Araba
    {
        //YAPICI METOD (Constructor)
        public Araba(string marka)
        {
            Console.WriteLine($"Yapıcı metod çalıştı.Araç {marka}");
        }
        // YIKICI METOD (Destructor)
        ~Araba()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Yıkıcı metod (finalizer) çalıştı!");
            Console.ResetColor();
        }
    }
}
