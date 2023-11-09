using System.ComponentModel.DataAnnotations;

namespace FiftyShadesOfErrorList_DATA.Enum
{
    public enum Egzersiz
    {
        [Display(Name ="Sık Sık (Haftada 1ten fazla)")]
        surekli,
        [Display(Name = "Nadiren (Ayda birkaç kez)")]
        bazen,
        [Display(Name ="Hiçbir zaman")]
        yildabirkaçkez
    }
}
