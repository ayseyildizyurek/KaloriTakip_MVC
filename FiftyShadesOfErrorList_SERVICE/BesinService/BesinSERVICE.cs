using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.BesinService
{
    public class BesinSERVICE : IBesinSERVICE
    {
        public void Ekle(Besin besin)
        {
            BaseDAL<Besin> baseDAL = new BaseDAL<Besin>();
            baseDAL.Ekle(besin);
        }

        public List<Besin> FiltreyeGoreGetir(string filter)
        {
            BesinDAL besinDAL = new BesinDAL();
          return besinDAL.FiltreyeGoreGetir(filter);
        }

        public void Guncelle(Besin besin)
        {
            BaseDAL<Besin> baseDAL = new BaseDAL<Besin>();
            baseDAL.Guncelle(besin);
        }

        public Besin IdyeGoreGetir(int id)
        {
            BaseDAL<Besin> baseDAL = new BaseDAL<Besin>();
            return baseDAL.IdyeGoreGetir(id);
        }
        public List<Besin> KosulaGoreGetir(Expression<Func<Besin, bool>> expression)
        {
            BaseDAL<Besin> baseDAL = new BaseDAL<Besin>();
            return baseDAL.KosulaGoreGetir(expression);
        }
        public void Sil(Besin besin)
        {
            BesinDAL besinDAL = new BesinDAL();
            besinDAL.Sil(besin);
        }
        public List<Besin> TumunuGetir()
        {
            BaseDAL<Besin> baseDAL = new BaseDAL<Besin>();
            return baseDAL.TumunuGetir();
        }
    }
}
