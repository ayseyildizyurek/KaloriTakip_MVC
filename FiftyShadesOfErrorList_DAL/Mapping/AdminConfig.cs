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
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Yöneticiler");
            
            builder.HasKey(x => x.Id);

            builder.Ignore(x => x.AdSoyad);
            
            builder.Ignore(x => x.Yas);

            builder.Property(x => x.Id)
                .HasColumnOrder(1);

            builder.Property(x => x.Ad)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .HasColumnOrder(2);

            builder.Property(x => x.Soyad)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .HasColumnOrder(3);

            builder.Property(x => x.Cinsiyet)
                .IsRequired()
                .HasColumnOrder(4);

            builder.Property(x => x.DogumTarihi)
                .IsRequired().HasColumnOrder(5).HasColumnName("Doğum_Tarihi");

            builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(50).HasColumnOrder(6);

            builder.Property(x=>x.Sifre)
                .IsRequired()
                .HasMaxLength(16).HasColumnOrder(7);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasMany(x => x.IstekSikayetler)
                .WithOne(x => x.Admin)
                .HasForeignKey(x => x.AdminId);
        }
    }
}
