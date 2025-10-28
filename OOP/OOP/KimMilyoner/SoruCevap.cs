using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP.KimMilyoner
//{
//    internal class SoruCevap
//    {
//        private string[] sorular =
//        {
//            "1. Türkiye Cumhuriyeti’nin ilk meclisi hangi şehirde açılmıştır?",
//            "2. Dünya’nın en derin noktası olarak bilinen Mariana Çukuru hangi okyanustadır?",
//            "3. Işık yılı hangi ölçü birimini ifade eder?",
//            "4. İnsan DNA’sı kaç kromozom içerir?",
//            "5. Osmanlı Devleti’nin son padişahı kimdir?",
//            "6. Türkiye’nin en büyük gölü hangisidir?",
//            "7. Hangi elementin atom numarası 79’dur?",
//            "8. 1919 yılında Samsun’a çıkan Mustafa Kemal Atatürk’ün görevi neydi?",
//            "9. Güneş’te gerçekleşen enerji üretim süreci hangi fiziksel olaya dayanır?",
//            "10. Rönesans hangi ülkede başlamıştır?",
//            "11. Elektronun varlığını keşfeden bilim insanı kimdir?",
//            "12. 0 Kelvin sıcaklığı neyi ifade eder?",
//            "13. Ege Denizi'nde yer alan en büyük ada hangisidir?",
//            "14. Bilgisayar ağlarında 'IP' kısaltması neyi ifade eder?",
//            "15. Modern fiziğin doğuşu hangi bilim insanının çalışmalarıyla başlamıştır?"
//        };
//        private string[,] secenekler =
//        {
//            {"A) İstanbul", "B) Ankara", "C) Sivas", "D) İzmir"},
//            {"A) Atlas Okyanusu", "B) Büyük Okyanus", "C) Hint Okyanusu", "D) Arktik Okyanusu"},
//            {"A) Zaman", "B) Hız", "C) Mesafe", "D) Enerji"},
//            {"A) 23", "B) 42", "C) 46", "D) 64"},
//            {"A) II. Abdülhamid", "B) V. Mehmet Reşat", "C) VI. Mehmet Vahdettin", "D) V. Murat"},
//            {"A) Tuz Gölü", "B) Van Gölü", "C) Beyşehir Gölü", "D) Eğirdir Gölü"},
//            {"A) Gümüş", "B) Demir", "C) Altın", "D) Bakır"},
//            {"A) Genel Müfettiş", "B) Ordu Komutanı", "C) Vali", "D) Eğitim Ataşesi"},
//            {"A) Fisyon", "B) Füzyon", "C) Kimyasal yanma", "D) Işınım"},
//            {"A) Fransa", "B) Almanya", "C) İtalya", "D) İngiltere"},
//            {"A) Isaac Newton", "B) J.J. Thomson", "C) Rutherford", "D) Niels Bohr"},
//            {"A) En düşük basınç", "B) Mutlak sıfır", "C) Kaynama noktası", "D) Donma noktası"},
//            {"A) Midilli", "B) Sakız Adası", "C) Rodos", "D) Girit"},
//            {"A) Internet Protocol", "B) Internal Process", "C) Input Port", "D) Integrated Program"},
//            {"A) Isaac Newton", "B) Galileo Galilei", "C) Albert Einstein", "D) Max Planck"}
//        };
//        private string[] dogruCevaplar =
//        {
//            "C", "B", "C", "C", "C",
//            "B", "C", "A", "B", "C",
//            "B", "B", "D", "A", "D"
//        };
//        public string SoruSor(int indexNumarasi)
//        {
//            string soru = sorular[indexNumarasi];
//            string cevaplar = "";
//            for (int i = 0; i < 4; i++)
//            {
//                cevaplar += " " + secenekler[indexNumarasi, i];
//            }
//            return $"\n{soru}\n\n {cevaplar}";
//        }

//        public bool CevapKontrol(int index, string gelenCevap)
//        {
//            string cevap = dogruCevaplar[index];
//            if (cevap == gelenCevap)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}
