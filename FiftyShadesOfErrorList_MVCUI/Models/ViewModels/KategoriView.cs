using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_MVCUI.Models.ViewModels
{
	public class KategoriView
	{
		public List<Kategori> KategoriListe { get; set; }
		public Kategori Kategori { get; set; } = new Kategori();
	}
}
