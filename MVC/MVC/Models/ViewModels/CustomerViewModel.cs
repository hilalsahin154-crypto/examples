using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class CustomerViewModel
    {
       
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

       
    }
}
