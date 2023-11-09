using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DAL.Interface;
using FiftyShadesOfErrorList_DATA.Abstract;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_DAL.Concrete
{

    public class BaseDAL<T> : IBaseDAL<T> where T : BaseEntity
    {
        DiyetAppContext db = new DiyetAppContext();

        public void Ekle(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public void Guncelle(T entity)
        {
            entity.GuncellemeTarihi = DateTime.Now;
            db.Update(entity);
            db.SaveChanges();
        }

        public T IdyeGoreGetir(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> KosulaGoreGetir(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public void Sil(T entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }

        public List<T> TumunuGetir()
        {
            return db.Set<T>().ToList();
        }
    }
}
