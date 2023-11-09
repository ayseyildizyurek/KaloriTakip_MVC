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
    public class AlinanBesinConfig : IEntityTypeConfiguration<AlinanBesin>
    {
        public void Configure(EntityTypeBuilder<AlinanBesin> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Tüketilen_Besinler");

            builder.Property(x => x.AlinanMiktar)
                .IsRequired()
                .HasColumnName("Tüketilen_Miktar");

            builder.Property(x=>x.Birim)
                .IsRequired();

            builder.Property(x => x.AlinanKalori)
                .IsRequired()
                .HasColumnName("Alınan_Kalori");

            builder.Property(x => x.Ogun)
                .IsRequired()
                .HasColumnName("Öğün");
        }
    }
}
