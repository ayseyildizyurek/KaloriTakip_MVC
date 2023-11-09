using FiftyShadesOfErrorList_DATA.Abstract;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class Kategori : BaseEntity
    {
        public string Ad { get; set; }
        public virtual ICollection<Besin> Besinler { get; set; }
        public Kategori()
        {
            Besinler = new HashSet<Besin>();
        }
    }
}