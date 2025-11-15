using DesignPattens.MeyvSuyuFactory.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory.Meyve
{
    public class MeyveService : IMeyveService
    {
        public MeyveLogger _meyveLogger;
        public MeyveService(MeyveLogger? logg) => _meyveLogger = logg;
        public void MeyveSuyuUret(string meyveAdi)
        {
            Console.WriteLine($"{meyveAdi} suyu üretime başlandi.");
            _meyveLogger.Log($"{meyveAdi} suyu üretildi.");
        }
    }
}
