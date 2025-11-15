using DesignPattens.MeyvSuyuFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.MeyvSuyuFactory
{
    public interface IMeyveSuyuFacrtry
    {
        public static IMeyve GetMeyve(string name)
        {
            switch (name)
            {
                case "elma":
                    return new Elma();
                case "nar":
                    return new Nar();
                case "portakal":
                    return new Portakal();
                case "şeftali":
                    return new Seftali();
                case "vişne":
                    return new Visne();
                default:
                    throw new Exception("Bilinmeyen meyve");
            }
        }
    }
}
