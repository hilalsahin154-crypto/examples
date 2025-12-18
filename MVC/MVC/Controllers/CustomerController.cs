using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        private static readonly string StaticUsername = "hilalshn_";
        private static readonly string StaticPassword = "0723";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (Request.Cookies["username"] != null)
            {
                return RedirectToAction("Index", "Product");
            }

            return View();
        }

        [HttpPost]

        public IActionResult Login(CustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == StaticUsername && model.Password == StaticPassword)
            {
                
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1)
                };

                Response.Cookies.Append("username", StaticUsername, options);


                return RedirectToAction("Index", "Product");
            }

            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            return View(model);
        }
        
        public IActionResult Logout()
        {
            Response.Cookies.Delete("username");
           

            return RedirectToAction("Login");
        }
    }

}
