using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class AlinanBesinDAL : BaseDAL<AlinanBesin>
    {
        public void Sil(AlinanBesin besin)
        {
            DiyetAppContext db = new DiyetAppContext();
            db.Remove(besin);
            db.SaveChanges();
        }
    }
}
