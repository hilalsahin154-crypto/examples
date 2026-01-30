using Microsoft.AspNetCore.Mvc;
using MVC_Petshop.Models;

namespace MVC_Petshop.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignIn> users = new()
        {
            new SignIn { UserName = "hilalshn_", Password = "0723" }
        };

        [HttpGet]
        public IActionResult Create()
        {
            if (Request.Cookies["LoginUser"] != null)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult Create(SignIn model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = users.FirstOrDefault(x =>
                x.UserName == model.UserName &&
                x.Password == model.Password);

            if (user != null)
            {
                Response.Cookies.Append(
                    "LoginUser",
                    user.UserName,
                    new CookieOptions
                    {
                        Expires = model.RememberMe
                            ? DateTimeOffset.Now.AddMinutes(60)
                            : DateTimeOffset.Now.AddMinutes(20),
                        HttpOnly = true
                    });

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Kullanıcı adı ya da şifre yanlış.";
            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("LoginUser");
            return RedirectToAction("Index", "Home");
        }
    }
}

