#region SINGLE RESPONSIBILITY PRINCIPLE(Tek Sorunluluk)
//// Bir sınıf yalnızca bir sorumluluğa sahip olmalıdır. Değişiklik gereksinimi yanlızca bu sorumluluğa göre olmalıdır
//using SOLID.SingleResponsibilty;

//StudentSevice studentSevice = new StudentSevice();
//studentSevice.CreatStuddent();

//MailService mailService = new MailService();
//mailService.SendMail("Mail konusu", "Mail içerigi");

#endregion
#region OPEN/ CLOSEDED PRINCIPLE (Açık/Kapalı)
//// Sınıflar genişlemeye açık, degişikliklere kapalı olmalıdır.
//using SOLID.OpenClose;

//Daire daire = new Daire(5);
//Console.WriteLine($"Dairenin Alanı: {daire.Alan()}");

//Kare kare = new Kare(5);
//Console.WriteLine($"Karenin Alanı: {kare.Alan()}");

#endregion
#region  LISKOV SUBSTİTUTION PRICIPLE
// Alt sınıflar, üst sınıfların yerine geçmeli ve sistem doğru şekilde çalışmaya 

using SOLID.LiskovSubstitution;

Eagle eagle = new Eagle();
eagle.Fly();

Penguen penguen = new Penguen();
penguen.Fly();

#endregion