#region 1.Kısım
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

using Metods;

OgrenciIsler ogrenci=new OgrenciIsler();
ogrenci.SelamVer();
ogrenci.SelamVer("Hilal");
Console.WriteLine($"Yasınız parametresiz: {ogrenci.YasHesapla()}");
Console.WriteLine($"Yasınız pareli: {ogrenci.YasHesapla(2001)}");
