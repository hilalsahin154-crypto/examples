using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class StudentViewModel
    {
        [Required(ErrorMessage = "Bu alan boş girilemez")]
        [DisplayName("Ad Soyad")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Bu alan boş girilemez")]
        [EmailAddress(ErrorMessage ="E-Posta formatı doğru degildir")]
        [DisplayName("E-Posta")]
        public string Email { get; set; }

        [Range(18,60,ErrorMessage="Yaş 18 ile 60 arasi olmalı")]
        [DisplayName("Yas")]
        public string Age { get; set; }

    }
}
