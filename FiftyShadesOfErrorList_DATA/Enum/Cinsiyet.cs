using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DATA.Enum
{
    public enum Cinsiyet
    {
        Erkek,
        [Display(Name = "Kadın")]
        Kadin, 
        Bilinmiyor
    }
}
