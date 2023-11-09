using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService
{
    public class KullaniciGecmisDetaySERVICE : IKullaniciGecmisDetaySERVICE
    {
        public void Ekle(KullaniciGecmisDetay kullaniciGecmisDetay)
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            baseDAL.Ekle(kullaniciGecmisDetay);
        }

        public void Guncelle(KullaniciGecmisDetay kullaniciGecmisDetay)
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            baseDAL.Guncelle(kullaniciGecmisDetay);
        }

        public KullaniciGecmisDetay IdyeGoreGetir(int id)
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            return baseDAL.IdyeGoreGetir(id);
        }

        public List<KullaniciGecmisDetay> KosulaGoreGetir(Expression<Func<KullaniciGecmisDetay, bool>> expression)
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            return baseDAL.KosulaGoreGetir(expression);
        }

        public KullaniciGecmisDetay KullaniciIdyeGoreGetir(int id)
        {
            KullaniciGecmisDetayDAL kullaniciGecmisDetayDAL=new KullaniciGecmisDetayDAL();
            return kullaniciGecmisDetayDAL.KullaniciIdyeGoreGetir(id);
        }

        public void Sil(KullaniciGecmisDetay kullaniciGecmisDetay)
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            baseDAL.Sil(kullaniciGecmisDetay);
        }

        public List<KullaniciGecmisDetay> TumunuGetir()
        {
            BaseDAL<KullaniciGecmisDetay> baseDAL = new BaseDAL<KullaniciGecmisDetay>();
            return baseDAL.TumunuGetir();
        }
    }
}
