#region SINGLE RESPONSIBILITY PRINCIPLE(Tek Sorunluluk)
//// bir sınıf yalnızca bir sorumluluğa sahip olmalıdır. değişiklik gereksinimi yanlızca bu sorumluluğa göre olmalıdır
//using SOLID.SingleResponsibilty;

//StudentSevice studentSevice = new StudentSevice();
//studentSevice.CreatStuddent();

//MailService mailService = new MailService();
//mailService.SendMail("Mail konusu", "Mail içerigi");

#endregion
#region OPEN/ CLOSEDED PRINCIPLE (Açık/Kapalı)
// Sınıflar genişlemeye açık, degişikliklere kapalı olmalıdır.
//using SOLID.OpenClose;

//Daire daire = new Daire(5);
//Console.WriteLine($"Dairenin Alanı: {daire.Alan()}");

//Kare kare = new Kare(5);
//Console.WriteLine($"Karenin Alanı: {kare.Alan()}");

#endregion
#region  LISKOV SUBSTİTUTION PRICIPLE
//Alt sınıflar, üst sınıfların yerine geçmeli ve sistem doğru şekilde çalışmaya 

//using SOLID.LiskovSubstitution;

//Eagle eagle = new Eagle();
//eagle.Fly();

//Penguen penguen = new Penguen();
//penguen.Fly();

#endregion
#region INTERFACE SEGREGATITON
//using SOLID.InterfaceSegregation;
//using SOLID.InterfaceSegregation.Machine;

//Human human = new Human();
//Bird bird = new Bird();

//human.Work();
//human.Talk();

//bird.Work();
//bird.Talk();
//bird.Fly();


//WashingMachine washingMachine = new WashingMachine();
//DeepFrezee deepFrezee = new DeepFrezee();

//deepFrezee.ElekricUs();
//deepFrezee.Freez();

//washingMachine.ElekricUs();
//washingMachine.Wosh();

#endregion
#region DEPENDENCY INVERSION

//using SOLID.Dependencyllnversion;

//Order order = new Order();
//order.Onayla();

#endregion
#region ÖDEV
//TODO: SOLID ile ilgili ornekler dazırlanıp sunum yapılacak

#region //TODO: SINGLE RESPONSIBILITY PRINCIPLE(Tek Sorunluluk) ile ilgili örnek yap Bitti

//using SOLID.ODEV.SingleResponsibilty;

//BookService bookService = new BookService();
//bookService.AddBook();

//NotificationService notificationService = new NotificationService();
//notificationService.SendNotification("Yeni kitap eklendi!");

#endregion
#region //TODO: OPEN/ CLOSEDED PRINCIPLE (Açık/Kapalı) ile ilgili örnek yap Bitti

using SOLID.ODEV.OpenClose;

IMusteri normal = new NormalMusteri();
Console.WriteLine($"Muşterinin ödeyecegi tutar: {normal.IndirimliFiyat(100)}TL");

IMusteri premium = new PremiumMusteri();
Console.WriteLine($"Premium muşterinin ödeyecegi tutar: {premium.IndirimliFiyat(100)}TL");

#endregion
#region //TODO: LISKOV SUBSTİTUTION PRICIPLE ile ilgili örnek yap Bitti

//using SOLID.ODEV.LiskovSubstitution;

//Apple apple = new Apple();
//apple.Taste();

//Lemon lemon = new Lemon();
//lemon.Taste();

#endregion
#region //TODO: INTERFACE SEGREGATITON ile ilgili örnek yap Bitti

//using SOLID.ODEV.InterfaceSegregation;

//Car car = new Car();
//Airplane airplane = new Airplane();

//car.Drive();

//airplane.Drive();
//airplane.Fly();

#endregion
#region //TODO: DEPENDENCY INVERSION ile ilgili örnek yap Bitti

//using SOLID.ODEV.Dependencyllnversion;

//Instructions instructions = new Instructions();
//instructions.Off();


#endregion
//SLAYT HAZIRLA Bitti
//SUNUMA HAZIRLAN

#endregion