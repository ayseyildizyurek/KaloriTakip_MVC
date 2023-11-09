using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KullaniciService
{
    public class KullaniciSERVICE : IKullaniciSERVICE
    {
        public void Ekle(Kullanici kullanici)
        {
            BaseDAL<Kullanici> baseDAL = new BaseDAL<Kullanici>();
            baseDAL.Ekle(kullanici);
        }

        public Kullanici EmaileGoreGetir(string email, string sifre)
        {
            KullaniciDAL kullaniciDal = new KullaniciDAL();
            return kullaniciDal.EmaileGoreGetir(email, sifre);
        }

        public void Guncelle(Kullanici kullanici)
        {
            BaseDAL<Kullanici> baseDAL = new BaseDAL<Kullanici>();
            baseDAL.Guncelle(kullanici);
        }

        public Kullanici IdyeGoreGetir(int id)
        {
            BaseDAL<Kullanici> baseDAL = new BaseDAL<Kullanici>();
            return baseDAL.IdyeGoreGetir(id);
        }

        public List<Kullanici> KosulaGoreGetir(Expression<Func<Kullanici, bool>> expression)
        {
            BaseDAL<Kullanici> baseDAL = new BaseDAL<Kullanici>();
            return baseDAL.KosulaGoreGetir(expression);
        }

        public void Sil(Kullanici kullanici)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            kullaniciDAL.Sil(kullanici);
        }

        public List<Kullanici> TumunuGetir()
        {
            BaseDAL<Kullanici> baseDAL = new BaseDAL<Kullanici>();
            return baseDAL.TumunuGetir();
        }
    }
}
