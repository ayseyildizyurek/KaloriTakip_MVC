using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DAL.Interface;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.AdminService
{
    public class AdminSERVICE : IAdminSERVICE
    {
        public void Ekle(Admin admin)
        {
            BaseDAL<Admin>baseDAL = new BaseDAL<Admin>();
            baseDAL.Ekle(admin);
        }

        public Admin EmaileGoreGetir(string email, string sifre)
        {
           AdminDAL adminDAL = new AdminDAL();
           return adminDAL.EmaileGoreGetir(email, sifre);
        }

        public void Guncelle(Admin admin)
        {
            BaseDAL<Admin> baseDAL = new BaseDAL<Admin>();
            baseDAL.Guncelle(admin);
        }

        public Admin IdyeGoreGetir(int id)
        {
            BaseDAL<Admin> baseDAL = new BaseDAL<Admin>();
            return baseDAL.IdyeGoreGetir(id);
        }

        public List<Admin> KosulaGoreGetir(Expression<Func<Admin, bool>> expression)
        {
            BaseDAL<Admin> baseDAL = new BaseDAL<Admin>();
            return baseDAL.KosulaGoreGetir(expression);

        }

        public void Sil(Admin admin)
        {
            BaseDAL<Admin> baseDAL = new BaseDAL<Admin>();
            baseDAL.Sil(admin);
        }

        public List<Admin> TumunuGetir()
        {
            BaseDAL<Admin> baseDAL = new BaseDAL<Admin>();
            return baseDAL.TumunuGetir();
        }
    }
}
