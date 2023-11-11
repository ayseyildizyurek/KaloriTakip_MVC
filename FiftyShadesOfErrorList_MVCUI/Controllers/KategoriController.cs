using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_MVCUI.Models.ViewModels;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using Microsoft.AspNetCore.Mvc;

namespace FiftyShadesOfErrorList_MVCUI.Controllers
{
	public class KategoriController : Controller
	{
		private readonly IKategoriSERVICE kategoriService = new KategorSERVICE();
		private KategoriView kategoriView = new KategoriView();

		public IActionResult Index()
		{
			kategoriView.KategoriListe = kategoriService.TumunuGetir();
			return View(kategoriView);
		}

		public IActionResult FiltreliKategoriListesi(string filtre)
		{
			kategoriView.KategoriListe = kategoriService.TumunuGetir();
			if (filtre == null)
			{
				return PartialView(kategoriView.KategoriListe);
			}
			else
			{
				kategoriView.KategoriListe = kategoriView.KategoriListe.Where(b => b.Ad.ToLower().Contains(filtre.ToLower())).ToList();
				return PartialView(kategoriView.KategoriListe);
			}
		}

		public IActionResult KategoriEkleDuzenle(int id = default)
		{
			if (id == default)
			{
				return PartialView(kategoriView.Kategori = new Kategori());
			}
			else
			{
				return PartialView(kategoriView.Kategori = kategoriService.IdyeGoreGetir(id));
			}
		}

		[HttpPost]
		public IActionResult KategoriEkleDuzenle(Kategori kategori, int id = default)
		{
			if (id == default)
			{
				kategoriService.Ekle(kategori);
				TempData["bilgi"] = "Kategori başarıyla eklendi";
			}
			else
			{
				var guncellenecekKategori = kategoriService.IdyeGoreGetir(id);
				guncellenecekKategori.Ad = kategori.Ad;
				kategoriService.Guncelle(guncellenecekKategori);
				TempData["bilgi"] = "Kategori başarıyla güncellendi";
			}
			return RedirectToAction("Index");
		}

		public IActionResult Sil(int id)
		{
			TempData["bilgi"] = "Kategori başarıyla silindi";
			kategoriService.Sil(kategoriService.IdyeGoreGetir(id));
			return RedirectToAction("Index");
		}
	}
}
