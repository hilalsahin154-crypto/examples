#region 1.Kısım
using Metods.opp;
//DortIslemParametreli(4, 2, global::DortIslem.Toplama);
//DortIslemParametreli(4, 2, global::DortIslem.Cıkartma);
//DortIslemParametreli(4, 2, global::DortIslem.Carpma);
//DortIslemParametreli(4, 2, global::DortIslem.Bolme);

//static void DortIslemParametreli(double sayi1, double sayi2, DortIslem islemTipi)
//{
//    switch (islemTipi)
//    {
//        case global::DortIslem.Toplama:
//            Console.WriteLine($"Toplama işleminin sonucu: {sayi1 + sayi2}");
//            break;
//        case global::DortIslem.Cıkartma:
//            Console.WriteLine($"Çıkartma işleminin sonucu: {sayi1 - sayi2}");
//            break;
//        case global::DortIslem.Bolme:
//            Console.WriteLine($"Çarpma işleminin sonucu: {sayi1 * sayi2}");
//            break;
//        case global::DortIslem.Carpma:
//            Console.WriteLine($"Bolme işleminin sonucu: {sayi1 / sayi2}");
//            break;
//        default:
//            break;
//    }
//}


#endregion

#region 2. Kısım
//static double DortIslemGeriDonuslu(int sayi1, int sayi2, DortIslem islemTipi)
//{
//    switch (islemTipi)
//    {
//        case DortIslem.Toplama:
//            return sayi1 + sayi2;
//        case DortIslem.Cıkartma:
//            return sayi1 - sayi2;
//        case DortIslem.Bolme:
//            return sayi1 / sayi2;
//        case DortIslem.Carpma:
//            return sayi1 * sayi2;
//        default:
//            return 0;
//    }
//}
//double sonuc = DortIslemGeriDonuslu(4, 2, DortIslem.Toplama);
//Console.WriteLine($"Toplama işleminin sonucu: {sonuc}");



//enum DortIslem
//{
//    Toplama,
//    Cıkartma,
//    Bolme,
//    Carpma
//}

#endregion

#region 3.Kısım

//using Metods;

//OgrenciIsler ogrenci=new OgrenciIsler();
//ogrenci.SelamVer();
//ogrenci.SelamVer("Hilal");
//Console.WriteLine($"Yasınız parametresiz: {ogrenci.YasHesapla()}");
//Console.WriteLine($"Yasınız pareli: {ogrenci.YasHesapla(2001)}");
#endregion

#region Ödev 1 ve Ödev 2 
#region Ödev 1

////TODO: Kullanıcıdan kahve siparişi alınacak(içecek türü, şeker sayısı, süt olsun mu?)
//using Metods;

//Console.Write("Lütfen içeçecek türünü seçiniz: 1- Türk kahvesi, 2- Latte, 3-Espresso :");
//string kaveTuru = Console.ReadLine();
//Console.Write("Lütfen şeker sayısı giriniz: ");
//int sekerSayisi = int.Parse(Console.ReadLine());
//Console.Write("Kahveniz sütlü mü olsun: (E/H) ");
//string sutKontrol = Console.ReadLine();
//bool sutVarmi = false;
//if (sutKontrol == "E")
//{
//sutVarmi = true;
//}
//switch (kaveTuru)
//{
//    case "1":
//    kaveTuru = "Türk Kavesi";
//    break;
//    case "2":
//    kaveTuru = "Latte";
//    break;
//    case "3":
//    kaveTuru = "Espresso";
//    break;
//}

//KahveSiparisi siparis = new KahveSiparisi();
//Console.WriteLine(siparis.Hazirla(kaveTuru, sekerSayisi, sutVarmi));
//Console.WriteLine($"Ödenecek tutar: {siparis.UcretiHesapla(kaveTuru)} TL");
#endregion

#region Ödev 2
//using Metods;

//Market market = new Market();
//market.FiyatGir();

#endregion

#endregion

#region Constructor Destructor
//using Metods.opp;

//Araba araba = new Araba("Audi");


//Ogrenci ogrenci = new Ogrenci();
//ogrenci.a1 = "ABVX213";
//ogrenci.a2 = "TESLKIWQEKQWOEQ";
//ogrenci.harcama = 4500;

//Console.WriteLine($"Api Key: {ogrenci.a1}, Api Secret: {ogrenci.a2}, Maaş: {ogrenci.harcama}");

//Kedi kedi = new Kedi();
//kedi.SesCikar("Miyav!!!!");
//Kopek kopek = new Kopek();
//kopek.SesCikar("Hav Hav!!!");

#endregion

