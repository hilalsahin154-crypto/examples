using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Petshop.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }   

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

