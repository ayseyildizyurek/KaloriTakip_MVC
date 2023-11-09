using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KategoriService
{
    public interface IKategoriSERVICE 
    {
        void Ekle(Kategori kategori);
        void Guncelle(Kategori kategori);
        void Sil(Kategori kategori);
        Kategori IdyeGoreGetir(int id);
        List<Kategori> TumunuGetir();
        List<Kategori> KosulaGoreGetir(Expression<Func<Kategori, bool>> expression);
    }
}
