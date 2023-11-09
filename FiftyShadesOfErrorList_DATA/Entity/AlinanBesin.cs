using FiftyShadesOfErrorList_DATA.Abstract;
using FiftyShadesOfErrorList_DATA.Enum;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class AlinanBesin : BaseEntity
    {
        public int BesinId { get; set; }
        public int KullaniciId { get; set; }
        public double AlinanMiktar { get; set; }
        public string Birim { get; set; }
        public double AlinanKalori { get; set; }
        public Ogun Ogun { get; set; }
        public virtual Besin Besin { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}