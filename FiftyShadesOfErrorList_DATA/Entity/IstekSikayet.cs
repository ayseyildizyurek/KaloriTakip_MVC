using FiftyShadesOfErrorList_DATA.Abstract;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DATA
{
    public class IstekSikayet : BaseEntity
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public bool OkunduMu { get; set; } 
        public int AdminId { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Admin Admin { get; set; }
    }
}