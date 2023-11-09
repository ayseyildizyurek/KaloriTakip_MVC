using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class AdminDAL : BaseDAL<Admin>
    {
        public Admin EmaileGoreGetir(string email, string sifre)
        {
            DiyetAppContext db = new DiyetAppContext();
            return db.Set<Admin>().FirstOrDefault(x => x.Email == email && x.Sifre == sifre);
        }
    }
}
