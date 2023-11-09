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
    public class BesinConfig : IEntityTypeConfiguration<Besin>
    {
        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.ToTable("Besinler");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ad)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(x=>x.Miktar)
                .IsRequired();

            builder.Property(x => x.Birim)
                .IsRequired();

            builder.Property(x => x.Kalori)
                .IsRequired();

            builder.Property(x => x.Porsiyon)
                .IsRequired();

            builder.HasOne(x => x.Kategori)
                .WithMany(x => x.Besinler);

            builder.HasMany(x => x.AlinanBesinler)
                .WithOne(x => x.Besin).HasForeignKey(x => x.BesinId);
        }
    }
}
