Baslangic:
try
{
	Console.Write("Lütfen bir sayı giriniz: ");
	int sayi = int.Parse(Console.ReadLine());
	Console.WriteLine("Girilen sayı " + sayi + "");
}
catch (Exception)
{
	Console.WriteLine("Uygulama hata verdi ama sen uygulamayı kullanmaya hala devam edebilirsin");
	goto Baslangic;

}