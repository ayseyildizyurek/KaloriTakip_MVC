using FiftyShadesOfErrorList_DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DAL.Mapping
{
    public class IstekSikayetConfig : IEntityTypeConfiguration<IstekSikayet>
    {
        public void Configure(EntityTypeBuilder<IstekSikayet> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.ToTable("İstek_Ve_Şikayetler");
            builder.Property(x => x.Baslik)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x=>x.Aciklama)
                .IsRequired()
                .HasColumnType("text");

            builder.Property(x=>x.OkunduMu)
                .HasDefaultValue(false);
        }
    }
}
