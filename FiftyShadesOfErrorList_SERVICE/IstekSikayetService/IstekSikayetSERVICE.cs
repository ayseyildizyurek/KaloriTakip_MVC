using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.IstekSikayetService
{
    public class IstekSikayetSERVICE : IIstekSikayetSERVICE
    {
        public void Ekle(IstekSikayet istekSikayet)
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            baseDAL.Ekle(istekSikayet);
        }

        public void Guncelle(IstekSikayet istekSikayet)
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            baseDAL.Guncelle(istekSikayet);
        }

        public IstekSikayet IdyeGoreGetir(int id)
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            return baseDAL.IdyeGoreGetir(id);
        }

        public List<IstekSikayet> KosulaGoreGetir(Expression<Func<IstekSikayet, bool>> expression)
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            return baseDAL.KosulaGoreGetir(expression);
        }

        public void Sil(IstekSikayet istekSikayet)
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            baseDAL.Sil(istekSikayet);
        }

        public List<IstekSikayet> TumunuGetir()
        {
            BaseDAL<IstekSikayet> baseDAL = new BaseDAL<IstekSikayet>();
            return baseDAL.TumunuGetir();
        }
    }
}
