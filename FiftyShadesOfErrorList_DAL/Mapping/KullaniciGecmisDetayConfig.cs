using FiftyShadesOfErrorList_DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DAL.Mapping
{
    public class KullaniciGecmisDetayConfig : IEntityTypeConfiguration<KullaniciGecmisDetay>
    {
        public void Configure(EntityTypeBuilder<KullaniciGecmisDetay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Kullanıcı_Geçmiş_Detaylar");
            
        }
    }
}
