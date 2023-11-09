using FiftyShadesOfErrorList_DATA.Abstract;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class KullaniciGecmisDetay : BaseEntity
    {
        public int KullaniciId { get; set; }
        public float Kilo { get; set; }
        public float Boy { get; set; }
        public virtual Kullanici Kullanici { get; set; }

    }
}