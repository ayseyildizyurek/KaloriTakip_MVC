using FiftyShadesOfErrorList_MVCUI.Models.ViewModels;
using FiftyShadesOfErrorList_SERVICE.AlinanBesinService;
using Microsoft.AspNetCore.Mvc;

namespace FiftyShadesOfErrorList_MVCUI.Controllers
{
	public class AlinanBesinController : Controller
	{
		private readonly IAlinanBesinSERVICE alinanBesinService = new AlinanBesinService();
        AlinanBesinView alinanBesinView=new AlinanBesinView();
        public IActionResult Index(int id)
		{
			alinanBesinView.AlinanBesinler = alinanBesinService.KosulaGoreGetir(id);

            return View(alinanBesinView);
		}
	}
}
