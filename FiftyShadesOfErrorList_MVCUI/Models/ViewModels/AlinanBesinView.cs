using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;

namespace FiftyShadesOfErrorList_MVCUI.Models.ViewModels
{
	public class AlinanBesinView
	{
		public Besin Besin { get; set; }
		public double AlinanMiktar { get; set; }
		public string Birim { get; set; }
		public double AlinanKalori { get; set; }
		public Ogun Ogun { get; set; }
		public DateTime KayitTarihi { get; set; } = DateTime.Now;

        public List<AlinanBesin> AlinanBesinler { get; set; }

    }
}
