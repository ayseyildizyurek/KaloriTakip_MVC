using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.AdminService
{
    public interface IAdminSERVICE
    {
        void Ekle(Admin admin);
        void Guncelle(Admin admin);
        void Sil(Admin admin);
        Admin  IdyeGoreGetir(int id);
        Admin EmaileGoreGetir(string email, string sifre);
        List<Admin> TumunuGetir();
        List<Admin> KosulaGoreGetir(Expression<Func<Admin, bool>> expression);
    }
}
