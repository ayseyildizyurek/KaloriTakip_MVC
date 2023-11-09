using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class KullaniciGecmisDetayDAL : BaseDAL<KullaniciGecmisDetay>
    {
        public KullaniciGecmisDetay KullaniciIdyeGoreGetir(int id)
        {
            DiyetAppContext db = new DiyetAppContext();

            return db.Set<KullaniciGecmisDetay>().OrderBy(x => x.KayitTarihi).LastOrDefault(x => x.KullaniciId == id);
        }
    }
}
