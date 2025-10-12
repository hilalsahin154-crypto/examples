DortIslem(4, 2, global::DortIslem.Toplama);
DortIslem(4, 2, global::DortIslem.Cıkartma);
DortIslem(4, 2, global::DortIslem.Carpma);
DortIslem(4, 2, global::DortIslem.Bolme);

static void DortIslem(double sayi1, double sayi2, DortIslem islemTipi)
{
    switch (islemTipi)
    {
        case global::DortIslem.Toplama:
            Console.WriteLine($"Toplama işleminin sonucu: {sayi1 + sayi2}");
            break;
        case global::DortIslem.Cıkartma:
            Console.WriteLine($"Çıkartma işleminin sonucu: {sayi1 - sayi2}");
            break;
        case global::DortIslem.Bolme:
            Console.WriteLine($"Çarpma işleminin sonucu: {sayi1 * sayi2}");
            break;
        case global::DortIslem.Carpma:
            Console.WriteLine($"Bolme işleminin sonucu: {sayi1 / sayi2}");
            break;
        default:
            break;
    }
}
    

enum DortIslem
{
    Toplama,
    Cıkartma,
    Bolme,
    Carpma
}