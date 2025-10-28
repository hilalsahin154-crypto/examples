//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP.KimMilyoner
//{
//    internal class YarismaMesajlari
//    {
//        public static void YarismaBaslangicMesajiVer()
//        {
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.WriteLine("======================================");
//            Console.WriteLine("       YARIŞMAMIZA HOŞ GELDİNİZ       ");
//            Console.WriteLine("======================================");
//            Console.ResetColor();
//        }
//        public static void YarişmaBaşliyorMesajVer()
//        {
//            Console.Title = " Yarışma Başlıyor! ";

//            Thread.Sleep(1000);
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("\n Kurallar basit: Bilinize güvenin !!");
//            Console.ResetColor();



//            // Geri sayım animasyonu
//            Console.ForegroundColor = ConsoleColor.Magenta;
//            for (int i = 3; i >= 1; i--)
//            {
//                Console.WriteLine($"\n {i}...");
//                Thread.Sleep(1000);
//            }
//            Console.ResetColor();

//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("\n YARIŞMA BAŞLADI! ");
//            Console.ResetColor();

//            // Bait alkiş efekti (Beep + animasyon)
//            YarısmaSesleri.AlkisSesiCikar(5, 0);

//            Console.WriteLine("\n\nBaşarılar dileriz");
//        }
//    }
//}
