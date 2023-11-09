using FiftyShadesOfErrorList_DATA.Abstract;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_DAL.Interface
{
    public interface IBaseDAL<T> where T : BaseEntity
    {
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
        T IdyeGoreGetir(int id);
        List<T> TumunuGetir();
        List<T> KosulaGoreGetir(Expression<Func<T, bool>> expression);

    }
}
