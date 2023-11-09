using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class KategoriDAL : BaseDAL<Kategori>
    {
        public void Sil(Kategori kategori)
        {
            DiyetAppContext db = new DiyetAppContext();
            db.Remove(kategori);
            db.SaveChanges();
        }
    }
}
