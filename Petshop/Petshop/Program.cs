using Petshop;

var products = new List<Product>
{
   new Product { ID = 1, Name="Royal Canin Kitten", Price = 850 },
   new Product { ID = 2, Name="Whiskas Tavuklu", Price = 450 },
   new Product { ID = 3, Name="Pro Plan Puppy", Price = 1100 },
   new Product { ID = 4, Name="ND Adult Dog", Price = 1350 },
   new Product { ID = 5, Name="Kedi Top Oyuncak", Price = 120 },
   new Product { ID = 6, Name="Köpek Çekiş Halatı", Price = 220 },
   new Product { ID = 7, Name="Balık Yemi", Price = 90 },
   new Product { ID = 8, Name="Akvaryum 50L", Price = 1800 },
   new Product { ID = 9, Name="Muhabbet Kafesi", Price = 950 },
   new Product { ID = 10, Name="Kuş Yemi", Price = 75 },
   new Product { ID = 11, Name="Kedi Tırmalama", Price = 650 },
   new Product { ID = 12, Name="Köpek Top", Price = 180 },
   new Product { ID = 13, Name="Reflex Somonlu", Price = 780 },
   new Product { ID = 14, Name="Acana Adult", Price = 1600 },
   new Product { ID = 15, Name="Kedi Peluş", Price = 200 }
};

//LINQ
var urunler = from p in products where (p.Price > 100) orderby p.Name select p;
foreach (var item in urunler)
{
    Console.WriteLine($"Linq --> " + item.Name + item.Price);
}

//LAMBDA
var lambdaUrunler = products.Where(x => x.Price > 100).ToList();
lambdaUrunler.ForEach(x => Console.WriteLine("Lambde --> " + x.Name));