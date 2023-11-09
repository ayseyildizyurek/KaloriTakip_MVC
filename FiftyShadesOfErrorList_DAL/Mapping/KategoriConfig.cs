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
    public class KategoriConfig : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x=>x.Id);
            
            builder.ToTable("Kategoriler");

            builder.Property(x => x.Ad)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");
        }
    }
}
