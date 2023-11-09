using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Enum
{
    public enum Ogun
    {
        Sabah,
        [Display(Name ="Öğle")]
        Ogle,
        [Display(Name ="Akşam")]
        Aksam,
        [Display(Name ="Ara Öğün")]
        Araogun

    }
}
