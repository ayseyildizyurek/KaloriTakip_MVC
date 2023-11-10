using FiftyShadesOfErrorList_DATA.Enum;

namespace FiftyShadesOfErrorList_DATA.Abstract
{
    public abstract class BaseKullanici : BaseEntity
    {
        private DateTime _dogumtarihi;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
        public Cinsiyet Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public DateTime DogumTarihi 
        {
            get { return _dogumtarihi; }
            set 
            {
                if (value > DateTime.Now)
                {
                    _dogumtarihi = DateTime.Now;
                }
                else { _dogumtarihi = value; }
            }
        }
        public int Yas { get { return DateTime.Now.Year - DogumTarihi.Year ; } }
    }
}
