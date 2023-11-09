using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyShadesOfErrorList_DAL.Mapping
{
    public class KullaniciConfig : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("Kullanıcılar");

            builder.HasKey(x => x.Id);

            builder.Ignore(x => x.AdSoyad);

            builder.Ignore(x => x.Yas);

            builder.Property(x => x.Id)
                .IsRequired()
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
                .IsRequired()
                .HasColumnName("Doğum_Tarihi")
                .HasColumnType("datetime2")
                .HasColumnOrder(5);

            builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnOrder(6);

            builder.Property(x => x.Sifre)
                .IsRequired()
                .HasMaxLength(16)
                .HasColumnName("Parola")
                .HasColumnOrder(7);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.VucutTipi)
                .IsRequired()
                .HasColumnName("Vücut_Tipi")
                .HasColumnOrder(8);

            builder.Property(x => x.Egzersiz)
                .IsRequired()
                .HasColumnOrder(9);
            builder.Property(x => x.GunlukAlinanKalori)
                .IsRequired()
                .HasColumnOrder(10);
            builder.Property(x => x.GunlukAlinanSuMiktari)
               .IsRequired()
               .HasColumnOrder(11);

            builder.Property(x => x.Status)
                .IsRequired()
                .HasDefaultValue(Status.Aktif)
                .HasColumnOrder(12);

            builder.HasMany(x => x.IstekSikayetler)
                .WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciId);

            builder.HasMany(x => x.AlinanBesinler)
                .WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciId);

            builder.HasMany(x => x.KullaniciDetaylari)
            .WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciId);


        }
    }
}
