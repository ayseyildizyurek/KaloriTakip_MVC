using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.KategoriService
{
    public class KategorSERVICE : IKategoriSERVICE
    {
        public void Ekle(Kategori kategori)
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            baseDAL.Ekle(kategori);
        }

        public void Guncelle(Kategori kategori)
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            baseDAL.Guncelle(kategori);
        }

        public Kategori IdyeGoreGetir(int id)
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            return baseDAL.IdyeGoreGetir(id);
        }

        public List<Kategori> KosulaGoreGetir(Expression<Func<Kategori, bool>> expression)
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            return baseDAL.KosulaGoreGetir(expression);
        }

        public void Sil(Kategori kategori)
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            baseDAL.Sil(kategori);
        }

        public List<Kategori> TumunuGetir()
        {
            BaseDAL<Kategori> baseDAL = new BaseDAL<Kategori>();
            return baseDAL.TumunuGetir();
        }
    }
}
