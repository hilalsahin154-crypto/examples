using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BilgiYarismasi
{
    internal class Soru
    {
        public string Metin { get; set; }
        public string[] Secenekler { get; set; }
        public char DogruCevap { get; set; }
        public bool JokerKullanildi { get; set; } = false;
        public Soru(string metin, string[] secenekler, char dogruCevap)
        {
            Metin = metin;
            Secenekler = secenekler;
            DogruCevap = dogruCevap;
        }
        public bool CevabiKonturolEt(char cevap)
        {
            return char.ToUpper(cevap) == DogruCevap;
        }
        public void SoruyuYazdir()
        {
            Console.WriteLine(Metin);
            char secenekHarf = 'A';
            foreach (string secenek in Secenekler)
            {
                Console.WriteLine($"{secenekHarf}) {secenek}");
                secenekHarf++;
            }
        }
        public void YariYariyaJoker()
        {
            if (JokerKullanildi)
            {
                Console.WriteLine("Joker kullanıldı !");
                Thread.Sleep(1000);
                return;
            }
            int dogruIndex = DogruCevap - 'A';
            int[] tumIndexsler = { 0, 1, 2, 3 };
            Random rnd = new Random();
            for (int i = 0; i < tumIndexsler.Length; i++)
            {
                int rast = rnd.Next(i, tumIndexsler.Length);
                (tumIndexsler[i], tumIndexsler[rast]) = (tumIndexsler[rast], tumIndexsler[i]);
            }

            int silinen = 0;
            foreach (int i in tumIndexsler)
            {
                if (i != dogruIndex && silinen < 2)
                {
                    Secenekler[i] = "";
                    silinen++;
                }

            }

            JokerKullanildi = true;
            Console.WriteLine("\nYarı yarıya joker kullanıldı! 2 yanlış şık kaldırıldı.\n");
            Thread.Sleep(1000);

        }
        public static Soru[] HazirSorular()
        {
            string metin1 = "1. İnsan vücudundaki en büyük iç organ hangisidir?";
            string[] secenekler1 = { "Karaciğer", "Kalp", "Akciğer", "Böbrek" };
            char cevap1 = 'A';

            string metin2 = " Hangi gezegen Güneş Sistemi’nde halkalarıyla ünlüdür?";
            string[] secenekler2 = { "Mars", "Jüpiter", "Satürn", "Neptün" };
            char cevap2 = 'C';

            string metin3 = "Türkiye’nin en uzun nehri hangisidir?";
            string[] secenekler3 = { "Kızılırmak", "Fırat", "Sakarya", "Dicle" };
            char cevap3 = 'A';

            string metin4 = "İlk Nobel Ödülü kazanan kadın kimdir?";
            string[] secenekler4 = { "Marie Curie", "Florence Nightingale", "Amelia Earhart", "Ada Lovelace" };
            char cevap4 = 'A';

            string metin5 = "Futbolda bir maçta bir takımın sahadaki oyuncu sayısı kaçtır?";
            string[] secenekler5 = { "9", "10", "11", "12" };
            char cevap5 = 'C';

            Soru[] sorular =
            {
                new Soru(metin1, secenekler1, cevap1),
                new Soru(metin2, secenekler2, cevap2),
                new Soru(metin3, secenekler3, cevap3),
                new Soru(metin4, secenekler4, cevap4),
                new Soru(metin5, secenekler5, cevap5)
            };

            return sorular;
        }
    }
}
