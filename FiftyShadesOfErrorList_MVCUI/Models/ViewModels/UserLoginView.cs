using System.ComponentModel.DataAnnotations;

namespace FiftyShadesOfErrorList_MVCUI.Models.ViewModels
{
    public class UserLoginView
    {
        [Display(Name = "E-posta")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Şifre")]
        [Required]
        public string Password { get; set; }
    }
}
