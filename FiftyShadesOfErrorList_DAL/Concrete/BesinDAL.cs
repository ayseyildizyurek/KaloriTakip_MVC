using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class BesinDAL : BaseDAL<Besin>
    {
        DiyetAppContext db = new DiyetAppContext();
        public void Sil(Besin besin)
        {
            db.Remove(besin);
            db.SaveChanges();
        }

        public List<Besin> FiltreyeGoreGetir(string filter)
        {
          return  db.Besinler.Where(x => x.Ad.ToLower().Contains(filter)).ToList();
        }
    }
}
