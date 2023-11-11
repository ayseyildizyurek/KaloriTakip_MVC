using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_MVCUI.Models.ViewModels;
using FiftyShadesOfErrorList_SERVICE.AlinanBesinService;
using FiftyShadesOfErrorList_SERVICE.BesinService;
using Microsoft.AspNetCore.Mvc;

namespace FiftyShadesOfErrorList_MVCUI.Controllers
{
	public class AlinanBesinController : Controller
	{
		private readonly IAlinanBesinSERVICE alinanBesinService = new AlinanBesinService();
		private readonly IBesinSERVICE besinService = new BesinSERVICE();
        AlinanBesinView alinanBesinView=new AlinanBesinView();
		AlinanBesinOgunEkleView besinOgunEkleView=new AlinanBesinOgunEkleView();
		private static int kullaniciId = 0;
		public IActionResult Index(int id)
		{
			kullaniciId = id;
			alinanBesinView.AlinanBesinler = alinanBesinService.KosulaGoreGetir(id);

            return View(alinanBesinView);
		}

		public IActionResult OgunEkle()
		{
			TempData["kullaniciId"] = kullaniciId;
			besinOgunEkleView.Besinler = besinService.TumunuGetir();
			return View(besinOgunEkleView);
		}

		[HttpPost]
		public IActionResult OgunEkle(int besinId, int porsiyonMiktar, string ogunAd)
		{
			Besin besin = besinService.IdyeGoreGetir(besinId);
			AlinanBesin alinanBesin = new AlinanBesin()
			{
				BesinId = besinId,
				KullaniciId = kullaniciId,
				AlinanMiktar = porsiyonMiktar,
				Birim = besin.Birim,
				AlinanKalori = besin.Kalori * porsiyonMiktar,
				Ogun = Enum.Parse<Ogun>(ogunAd)
			};
			alinanBesinService.Ekle(alinanBesin);
			return RedirectToAction("Index","AlinanBesin", new { id = kullaniciId });
		}
	}
}
