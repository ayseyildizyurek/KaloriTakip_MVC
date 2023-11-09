using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService
{
    public interface IKullaniciGecmisDetaySERVICE
    {
        void Ekle(KullaniciGecmisDetay kullaniciGecmisDetay);
        void Guncelle(KullaniciGecmisDetay kullaniciGecmisDetay);
        void Sil(KullaniciGecmisDetay kullaniciGecmisDetay);
        KullaniciGecmisDetay IdyeGoreGetir(int id);
        KullaniciGecmisDetay KullaniciIdyeGoreGetir(int id);
        List<KullaniciGecmisDetay> TumunuGetir();
        List<KullaniciGecmisDetay> KosulaGoreGetir(Expression<Func<KullaniciGecmisDetay, bool>> expression);
    }
}
