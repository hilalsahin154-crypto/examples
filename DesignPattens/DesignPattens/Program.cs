
//using DesignPattens.Singleton;
//using DesignPattens.Student;

//var logger = Logger.GetLogger();
//logger.Log("Sistem sağlıklı Çalıştı");

//StudentService studentService = new StudentService(logger);
//studentService.Add();
//studentService.Delete();
//studentService.List();
//studentService.Update();

using DesignPattens.Factory;

var sekilDaire = SekilFactory.GetSekil("daire");
var sekilKare = SekilFactory.GetSekil("kare");
sekilDaire.Ciz();
sekilKare.Ciz();