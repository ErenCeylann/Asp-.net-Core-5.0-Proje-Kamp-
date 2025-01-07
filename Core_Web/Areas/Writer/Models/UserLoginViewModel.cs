using System.ComponentModel.DataAnnotations;

namespace Core_Web.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adını Girin...!")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi Girin...!")]
        public string Password { get; set; }
    }
}
