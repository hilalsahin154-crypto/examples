#region SINGLETON PATTERN
//using DesignPattens.Singleton;
//using DesignPattens.Student;

//var logger = Logger.GetLogger();
//logger.Log("Sistem sağlıklı Çalıştı");

//StudentService studentService = new StudentService(logger);
//studentService.Add();
//studentService.Delete();
//studentService.List();
//studentService.Update();
#endregion
#region FACTORY PATTERN
//using DesignPattens.Factory;

//var sekilDaire = SekilFactory.GetSekil("daire");
//var sekilKare = SekilFactory.GetSekil("kare");
//sekilDaire.Ciz();
//sekilKare.Ciz();
#endregion

#region Ödev
using DesignPattens.MeyvSuyuFactory;
using DesignPattens.MeyvSuyuFactory.Meyve;
using DesignPattens.MeyvSuyuFactory.Singleton;

MeyveLogger logger = MeyveLogger.GetMeyveLogger();

IMeyveService meyveService = new MeyveService(logger);
meyveService.MeyveSuyuUret("elma");
var meyveElma = IMeyveSuyuFacrtry.GetMeyve("elma");
meyveElma.Uret();
meyveService.MeyveSuyuUret("nar");
var meyveNar = IMeyveSuyuFacrtry.GetMeyve("nar");
meyveNar.Uret();
meyveService.MeyveSuyuUret("portakal");
var meyvePortakal = IMeyveSuyuFacrtry.GetMeyve("portakal");
meyvePortakal.Uret();
meyveService.MeyveSuyuUret("şeftali");
var meyveSeftali = IMeyveSuyuFacrtry.GetMeyve("şeftali");
meyveSeftali.Uret();
meyveService.MeyveSuyuUret("vişne");
var meyveVisne = IMeyveSuyuFacrtry.GetMeyve("vişne");
meyveVisne.Uret();
#endregion

#region STRATEGY PATTERN

//using DesignPattens.Stratagy;

//var cebimdekipara = 1000;
//double anlikfiyat = 0;
//Console.Write("Lütfen ürün kodunu soyle:");
//string kod = Console.ReadLine();
//if (kod == "adidas")
//    anlikfiyat = 1100;
//else if (kod == "zara")
//    anlikfiyat = 1300;
//else
//    anlikfiyat = 1000;
//if (anlikfiyat > cebimdekipara)
//{
//    //Kredi kart
//    var f = new FiyatStragy { strateji = new Yuzde10() };
//    Console.WriteLine($"Ödeme yöntemi kredi kartı --> ürün fiyati {anlikfiyat}, indirimili fiyat {f.Hesapla(anlikfiyat)}");
//}
//else
//{
//    //Nakit
//    var f = new FiyatStragy { strateji = new Yuzde20() };
//    Console.WriteLine($"Ödeme yöntemi nakit --> ürün fiyati {anlikfiyat}, indirimili fiyat {f.Hesapla(anlikfiyat)}");
//}


#endregion