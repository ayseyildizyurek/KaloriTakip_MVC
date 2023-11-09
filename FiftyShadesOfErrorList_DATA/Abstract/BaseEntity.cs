namespace FiftyShadesOfErrorList_DATA.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
    }
}
