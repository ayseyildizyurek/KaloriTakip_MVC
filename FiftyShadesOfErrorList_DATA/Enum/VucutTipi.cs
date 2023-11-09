using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Enum
{
    public enum VucutTipi
    {
        [Display(Name ="İnce Beden")]
        incebeden,
        [Display(Name ="Orta Beden")]
        ortabedeb,
        [Display(Name = "Büyük Beden")]
        buyukbeden
    }
}
