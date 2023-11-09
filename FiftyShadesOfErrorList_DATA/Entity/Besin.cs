using FiftyShadesOfErrorList_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class Besin : BaseEntity
    {
        public string Ad { get; set; }
        public double Miktar { get; set; }
        public string Birim { get; set; }
        public double Kalori { get; set; }
        public string? ResimYolu { get; set; }
        public string Porsiyon { get; set; }
        public double? Karbonhidrat { get; set; }
        public double? Protein { get; set; }
        public double? Yag { get; set; }
        public  int  KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<AlinanBesin> AlinanBesinler { get; set; }

        public Besin()
        {
            AlinanBesinler = new HashSet<AlinanBesin>();
        }
    }
}
