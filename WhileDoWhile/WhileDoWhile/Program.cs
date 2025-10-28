#region WHILE DO
Console.Write("Kahveyi kim içiyor? :");
string kahveIcen = Console.ReadLine();
Console.Write($"{kahveIcen} kahvesini kaç yudumda içer? :");
int yudumSayisi = int.Parse(Console.ReadLine());
int yusumIndex = 0;

while(yudumSayisi > 0)
{
    Console.WriteLine($"{kahveIcen} kahvesinin {yusumIndex + 1}. yudumunu içiyor :)");
    Thread.Sleep(3000);
    yudumSayisi--;
    yusumIndex++;
}
Console.WriteLine($"{kahveIcen} kahvesini toplam {yusumIndex} yudum içti.");
#endregion
#region DO WHILE DÖNGÜSÜ
int sayi = 1;
do
{
    Console.WriteLine($"Sayı: {sayi}");
    sayi++;
}
while (sayi <= 5);

#endregion