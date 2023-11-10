using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FiftyShadesOfErrorList_MVCUI.Models.ViewModels
{
    public class UserCreateView
    {
        [Required] 
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Display(Name = "E-posta")]
        [Required]
        public string Email { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }=DateTime.Now;

        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        [StringLength(16,ErrorMessage ="Şifre en az 8 en fazla 16 karakter olmalıdır.",MinimumLength =8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.")]
        [Required]
        public string Sifre { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Required]
        [Compare("Sifre", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string SifreTekrar { get; set; }

        public List<SelectListItem> CinsiyetListesi { get; set; }

        
    }
}
