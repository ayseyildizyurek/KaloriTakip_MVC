using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.BesinService
{
    public interface IBesinSERVICE
    {
        void Ekle(Besin besin);
        void Guncelle(Besin besin);
        void Sil(Besin besin);
        Besin IdyeGoreGetir(int id);
        List<Besin> TumunuGetir();
        List<Besin> KosulaGoreGetir(Expression<Func<Besin, bool>> expression);
        List<Besin> FiltreyeGoreGetir(string filter);
    }
}
