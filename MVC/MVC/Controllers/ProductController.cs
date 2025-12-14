using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new List<Product> {
        new Product{ Id = 1, Name = "Kedi Maması" },
        new Product{ Id = 2, Name = "Köpek Maması" },
        new Product{ Id = 3, Name = "Kuş Yemi" },
        new Product{ Id = 4, Name = "Balık Yemi" },
        new Product{ Id = 5, Name = "Kedi Kumu" },
        new Product{ Id = 6, Name = "Köpek Tasması" },
        new Product{ Id = 7, Name = "Gezdirme Kayışı" },
        new Product{ Id = 8, Name = "Kedi Tırmalama Tahtası" },
        new Product{ Id = 9, Name = "Evcil Hayvan Oyuncakları" },
        new Product{ Id = 10, Name = "Kedi-Köpek Şampuanı" },
        new Product{ Id = 11, Name = "Kuş Kafesi" },
        new Product{ Id = 12, Name = "Akvaryum Filtresi" },
        new Product{ Id = 13, Name = "Mama ve Su Kabı" },
        new Product{ Id = 14, Name = "Taşıma Çantası" },
        new Product{ Id = 15, Name = "Tüy Toplama Fırçası" }
    };

        private static int _idCounter = 16;

        // Listeleme Sayfası
        public IActionResult Index()
        {
            return View(_products);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            model.Id = _idCounter;
            _idCounter++;
            _products.Add(model);
            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                product.Name = model.Name;
            }

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                _products.Remove(product);

            }
            return RedirectToAction("Index");
        }
    }
}
