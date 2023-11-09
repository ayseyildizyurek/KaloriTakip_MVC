using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KullaniciService
{
    public interface IKullaniciSERVICE
    {
        void Ekle(Kullanici kullanici);
        void Guncelle(Kullanici kullanici);
        void Sil(Kullanici kullanici);
        Kullanici EmaileGoreGetir(string email, string sifre);
        Kullanici IdyeGoreGetir(int id);
        List<Kullanici> TumunuGetir();
        List<Kullanici> KosulaGoreGetir(Expression<Func<Kullanici, bool>> expression);
    }
}
