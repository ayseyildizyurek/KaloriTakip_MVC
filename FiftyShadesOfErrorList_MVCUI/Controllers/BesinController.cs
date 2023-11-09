using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_SERVICE.BesinService;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiftyShadesOfErrorList_MVCUI.Controllers
{
	public class BesinController : Controller
	{
		private readonly IBesinSERVICE besinSERVICE = new BesinSERVICE();
		private readonly IKategoriSERVICE kategoriSERVICE = new KategorSERVICE();
		List<Besin> besinListe = new List<Besin>();

		public IActionResult Index()
		{
			return View(besinSERVICE.TumunuGetir());
		}

		public IActionResult FiltreliBesinListesi(string filtre)
		{
			besinListe = besinSERVICE.TumunuGetir();

			if (filtre == null)
			{
				return PartialView(besinListe);
			}
			else
			{
				return PartialView(besinListe.Where(b => b.Ad.ToLower().Contains(filtre.ToLower())));
			}
		}

		public IActionResult BesinEkleDuzenle(int id = default)
		{
			ViewBag.kategoriList = kategoriSERVICE.TumunuGetir().Select(x => new SelectListItem
			{
				Text = x.Ad,
				Value = x.Id.ToString()
			}).ToList();

			if (id == default)
			{
				return View(new Besin());
			}
			else
			{
				return View(besinSERVICE.IdyeGoreGetir(id));
			}
		}

		[HttpPost]
		public IActionResult BesinEkleDuzenle(Besin besin,int id = default)
		{
            if (id==default)
            {
				besinSERVICE.Ekle(besin);
                TempData["bilgi"] = "Besin başarıyla eklendi";
            }
            else
            {
				var guncellenecekBesin=besinSERVICE.IdyeGoreGetir(id);
				guncellenecekBesin.Ad=besin.Ad;
				guncellenecekBesin.Kalori=besin.Kalori;
				guncellenecekBesin.Protein=besin.Protein;
				guncellenecekBesin.Miktar=besin.Miktar;
				guncellenecekBesin.Porsiyon=besin.Porsiyon;
				guncellenecekBesin.Yag=besin.Yag;
				guncellenecekBesin.Birim=besin.Birim;
				guncellenecekBesin.Karbonhidrat=besin.Karbonhidrat;
				guncellenecekBesin.KategoriId=besin.KategoriId;
				besinSERVICE.Guncelle(guncellenecekBesin);
                TempData["bilgi"] = "Besin başarıyla güncellendi";
            }
			return RedirectToAction("Index");
		}

		public IActionResult Detay(int id)
		{
			return View(besinSERVICE.IdyeGoreGetir(id));
		}

		public IActionResult Sil(int id)
		{
			TempData["bilgi"] = "Besin başarıyla silindi";
			besinSERVICE.Sil(besinSERVICE.IdyeGoreGetir(id));
			return RedirectToAction("Index");
		}
	}
}
