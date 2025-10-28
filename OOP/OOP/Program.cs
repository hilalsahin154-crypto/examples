#region Constructor/Desctructor
// Ödev

//using OOP.Constructor_Desctructor;

//Araba araba = new Araba("Audi");

#endregion
#region Encapsulation (Kapsülleme)
// Ödev

//using OOP.Encapsulation;

//Ogrenci ogrenci = new Ogrenci();
//ogrenci.a1 = "ABVX213";
//ogrenci.a2 = "TESLKIWQEKQWOEQ";
//ogrenci.harcama = 4500;

//Console.WriteLine($"Api Key: {ogrenci.a1}, Api Secret: {ogrenci.a2}, Maaş: {ogrenci.harcama}");
#endregion
#region Inherretace (Kalıtım)
// Ödev

//using OOP.Inherretace;

//Kedi kedi = new Kedi();
//kedi.SesCikar("Miyav!!!!");
//Kopek kopek = new Kopek();
//kopek.SesCikar("Hav Hav!!!");

#endregion
#region Polymorphism (Çok bicimlilik)

//using OOP.Polymorphism;

//Dog dog = new Dog();
//dog.Sonund();

//Cat cat = new Cat();
//cat.Sonund();

#endregion
#region Kim milyener olmak ister yarışması
////TODO: Sunucu karşılama yapar

//using OOP;
//using OOP.KimMilyoner;

//YarismaMesajlari.YarismaBaslangicMesajiVer();
//YarısmaSesleri.AlkisSesiCikar(5, 2000);
//string[] yarişmacilar = { "Hilal", "Sevde", "Alper" };
//Random rnd = new Random();
////TODO: Gündelik hayattan sohbet edilir
//Başlangic:
//Console.ForegroundColor = ConsoleColor.Green;
//Thread.Sleep(1000);
//Console.Write($"(Sunucu) Merhaba {yarişmacilar[rnd.Next(0, 3)]} yarırşmamıza hoş geldiniz. Heycanlı mısınız? (E/H): ");
//string heyecanCevap = Console.ReadLine();
//switch (heyecanCevap.ToUpper())
//{
//    case "E":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Thread.Sleep(1000);
//        Console.WriteLine("(Sunucu) Heyecanlı olmanıza gerek yok. Sakin olmanız size yarışmada başarılı olma şansınızı artırır. Bol şans diliyorum.");
//        break;
//    case "H":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Thread.Sleep(1000);
//        Console.WriteLine("(Sunucu) Süper. Sakin olmanız size yarışmada başarılı olma şansınızı artırır. Bol şans diliyorum");
//        break;
//    default:
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("(Sunucu) Yanlış cevap verdiniz. Ben size heyecanlı mısınız diye soru sordum ?");
//        goto Başlangic;
//}
//Thread.Sleep(2000);
//Console.ForegroundColor = ConsoleColor.Magenta;
////TODO: Hazır olma mesajı verilir
//Console.Write("(Sunucu) Şimdi !!! Yarışmaya başlayalım mı ? (E/H) :");
//string yarismaBaslangicCevap = Console.ReadLine();
//if (yarismaBaslangicCevap.ToUpper().Equals("E"))
//{
//    int kazanc = 1000;
//    YarismaMesajlari.YarişmaBaşliyorMesajVer();
//    SoruCevap soruCevap = new SoruCevap();
//    for (int i = 0; i < 15; i++)
//    {
//    SoruyuTekrarla:
//        Console.WriteLine(soruCevap.SoruSor(i));
//        Console.Write("Cevabınız: ");
//        string cevap = Console.ReadLine();
//        Thread.Sleep(2000);
//        if (cevap.ToUpper() == "A" || cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
//        {
//            bool cevapDonus = soruCevap.CevapKontrol(i, cevap.ToUpper());
//            if (!cevapDonus)
//            {
//                Console.WriteLine("Tühhh !! Elendiniz !!. Yarışmacımıza kocaman bir alkış !!!!!!!");
//                YarısmaSesleri.AlkisSesiCikar(20, 0);
//                Console.WriteLine($"Kazancınız: {kazanc} TL");
//                break;
//            }
//            else
//            {
//                kazanc += 1000;
//                YarısmaSesleri.AlkisSesiCikar(5, 0);
//                Console.WriteLine("Tebrikler !! Cevabınız doğru !!  ");
//            }
//            Console.WriteLine($"Kazancınız: {kazanc} TL");

//        }
//        else
//        {
//            Console.Write("(Sunucu) Sen kafayı mı yedin? Şıklar belli sen ne seçtin ? Soruyu tekrarlıyorum. İyi dinle.....");
//            Thread.Sleep(1000);
//            goto SoruyuTekrarla;
//        }

//    }
//}
//else
//{
//    Thread.Sleep(1000);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.Write("(Sunucu) Anladım! Hazır olduğunuzda lütfen tekrar yarışmamıza katılın. Size yol parası hediye ediyoruz !!! Alkışlar yarışmacımız için !!!");
//    YarısmaSesleri.AlkisSesiCikar(10, 2000);

//}

//Console.ReadKey();

#endregion
#region Bilgi Yarışması
using OOP.BilgiYarismasi;

Console.Write("Bilgi Yarışmasına Hoş Geldin!\nLütfen adını gir: "); 
string oyuncuAdi = Console.ReadLine();
Thread.Sleep(2000);
Console.WriteLine($"\nHoş geldin {oyuncuAdi}! Yarışma başlıyor...\n");
Thread.Sleep(1000);

Soru[] sorular = Soru.HazirSorular();

Random rnd = new Random();

for (int i = sorular.Length - 1; i > 0; i--) 
{
    int j = rnd.Next(i + 1);
    (sorular[i], sorular[j]) = (sorular[j], sorular[i]); 
}

int puan = 0;
bool jokerKullanildi = false;

foreach (Soru soru in sorular)
{
    soru.SoruyuYazdir();

    Console.Write("\nCevabınız (A/B/C/D veya J=Joker): ");
    int giris = Console.Read();  
    char cevap = char.ToUpper((char)giris);  
    Console.ReadLine();

    if (cevap == 'J' && !jokerKullanildi)
    {
        soru.YariYariyaJoker();
        jokerKullanildi = true;

        soru.SoruyuYazdir();
        Console.Write("\nCevabınız (A/B/C/D): ");
        giris = Console.Read();  
        cevap = char.ToUpper((char)giris);
        Console.ReadLine();

    }

    if (soru.CevabiKonturolEt(cevap))
    {
        Console.WriteLine("Doğru cevap!\n");
        puan += 10;
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine($"Yanlış cevap! Doğru cevap: {soru.DogruCevap}");
        Console.WriteLine($"\nOyun bitti {oyuncuAdi}. Toplam puanın: {puan}");
        Console.ReadLine();
        return;
    }
}
Console.WriteLine($"\n Tebrikler {oyuncuAdi}! Tüm soruları bildin. Toplam puanın: {puan}");
Console.ReadLine();


#endregion




