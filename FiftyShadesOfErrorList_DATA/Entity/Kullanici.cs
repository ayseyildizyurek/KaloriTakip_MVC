using FiftyShadesOfErrorList_DATA.Abstract;
using FiftyShadesOfErrorList_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Entity
{
    public class Kullanici : BaseKullanici
    {
        public VucutTipi VucutTipi { get; set; }
        public Egzersiz Egzersiz { get; set; }
        public int GunlukAlinanKalori { get; set; }
        public int GunlukAlinanSuMiktari { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<IstekSikayet> IstekSikayetler { get; set; }
        public virtual ICollection<AlinanBesin> AlinanBesinler { get; set; }
        public virtual ICollection<KullaniciGecmisDetay> KullaniciDetaylari { get; set; }

        public Kullanici()
        {
            IstekSikayetler = new HashSet<IstekSikayet>();
            AlinanBesinler = new HashSet<AlinanBesin>();
            KullaniciDetaylari = new HashSet<KullaniciGecmisDetay>();
        }
    }
}
