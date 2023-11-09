using FiftyShadesOfErrorList_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class Admin : BaseKullanici
    {
        public virtual ICollection<IstekSikayet> IstekSikayetler { get; set; }

        public Admin()
        {
            IstekSikayetler = new HashSet<IstekSikayet>();
        }
    }
}
