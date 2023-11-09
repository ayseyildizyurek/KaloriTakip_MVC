using FiftyShadesOfErrorList_DATA;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.IstekSikayetService
{
    public interface IIstekSikayetSERVICE
    {
        void Ekle(IstekSikayet istekSikayet);
        void Guncelle(IstekSikayet istekSikayet);
        void Sil(IstekSikayet istekSikayet);
        IstekSikayet IdyeGoreGetir(int id);
        List<IstekSikayet> TumunuGetir();
        List<IstekSikayet> KosulaGoreGetir(Expression<Func<IstekSikayet, bool>> expression);
    }
}
