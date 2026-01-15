using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Petshop.Models;
using System.Diagnostics;


namespace MVC_Petshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _projectContext;

        public HomeController(ILogger<HomeController> logger, ProjectContext projectContext)
        {
            _logger = logger;
            _projectContext = projectContext;
        }

        public IActionResult Index()
        {
            var categories = _projectContext.Categories.ToList();
            var products = _projectContext.Products
                .Include(p => p.ProductImages)
                .ToList();
            return View((categories, products));
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }

}

