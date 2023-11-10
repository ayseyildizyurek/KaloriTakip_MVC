using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_MVCUI.Models.ViewModels;
using FiftyShadesOfErrorList_SERVICE.AdminService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiftyShadesOfErrorList_MVCUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IAdminSERVICE adminService=new AdminSERVICE();
        private readonly IKullaniciSERVICE kullaniciService=new KullaniciSERVICE();
        UserCreateView userCreateView=new UserCreateView();
        UserLoginView userLoginView=new UserLoginView();
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginView model)
        {
           var admin= adminService.EmaileGoreGetir(model.Email,model.Password);
           var user= kullaniciService.EmaileGoreGetir(model.Email,model.Password);
            if (user!=null)
            {
                return RedirectToAction("Index", "AlinanBesin", new { id = user.Id });
            }
            else if (admin!=null)
            {
                return RedirectToAction("Index", "Besin");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            userCreateView.CinsiyetListesi=GetCinsiyetListesi();
            return View(userCreateView);
        }

        [HttpPost]
        public IActionResult Register(UserCreateView model)
        {
            model.CinsiyetListesi =GetCinsiyetListesi();
            
                if (kullaniciService.EmaileGoreGetir(model.Email, model.Sifre) == null)
                {
                    Kullanici user = new Kullanici();
                    user.Email = model.Email;
                    user.Ad = model.Ad;
                    user.Soyad = model.Soyad;
                    user.DogumTarihi = model.DogumTarihi;
                    user.Cinsiyet =model.Cinsiyet;
                    user.Sifre = model.Sifre;
                    kullaniciService.Ekle(user);
                    return RedirectToAction("Index", "AlinanBesin");
                }
                else
                {
                    ViewBag.info="Kullanıcı zaten mevcut.";
                }
            
            return View(model);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        private  List<SelectListItem> GetCinsiyetListesi()
        {
            var cinsiyetListesi = Enum.GetValues(typeof(Cinsiyet))
                                      .Cast<Cinsiyet>()
                                      .Select(c => new SelectListItem
                                      {
                                          Text = Enum.GetName(typeof(Cinsiyet), c),
                                          Value = c.ToString()
                                      })
                                      .ToList();

            return cinsiyetListesi;
        }

    }
}
