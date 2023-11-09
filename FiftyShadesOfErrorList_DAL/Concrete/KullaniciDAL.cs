using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class KullaniciDAL : BaseDAL<Kullanici>
    {
        DiyetAppContext db = new DiyetAppContext();
        public Kullanici EmaileGoreGetir(string email, string sifre)
        {
            return db.Set<Kullanici>().FirstOrDefault(x => x.Email == email && x.Sifre == sifre);
        }

        public void Sil(Kullanici entity)
        {
            entity.Status = Status.Pasif;
            db.Update(entity);
            db.SaveChanges();
        }
    }
}
