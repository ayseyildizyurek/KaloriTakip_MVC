using FiftyShadesOfErrorList_DAL.Mapping;
using FiftyShadesOfErrorList_DATA;
using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FiftyShadesOfErrorList_DAL.Context
{
    public class DiyetAppContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<AlinanBesin> AlinanBesinler { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<IstekSikayet> IstekSikayetler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciGecmisDetay> KullaniciGecmisDetaylar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8JB5AHL\\SQLEXPRESS;Initial Catalog=DiyetProje;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseLazyLoadingProxies();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    FileStream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\BesinData.xml", FileMode.Open);

        //    XDocument besinler = XDocument.Load(stream); 


        //    var besin = besinler.Element("Besinler").Elements("Besin");
        //    foreach (var item in besin)
        //    {
        //        modelBuilder.Entity<Besin>().HasData(new Besin
        //        {
        //            Id = Convert.ToInt32(item.Attribute("BesinID").Value),
        //            Ad = item.Element("BesinAdi").Value,
        //            Miktar = Convert.ToDouble(item.Element("Miktar").Value),
        //            Birim = item.Element("Birim").Value,
        //            Porsiyon = item.Element("Porsiyon").Value,
        //            Karbonhidrat = Convert.ToDouble(item.Element("Karbonhidrat").Value),
        //            Protein = Convert.ToDouble(item.Element("Protein").Value),
        //            Yag = Convert.ToDouble(item.Element("Yag").Value),
        //            Kalori = Convert.ToDouble(item.Element("Kalori").Value),
        //            KategoriId = Convert.ToInt32(item.Element("KategoriID").Value)
        //        });
        //    }

        //    FileStream stream2 = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\KategoriData.xml", FileMode.Open);
        //    XDocument kategoriler = XDocument.Load(stream2); 

        //    var kategori = kategoriler.Element("Kategoriler").Elements("Kategori");

        //    foreach (var item in kategori)
        //    {
        //        modelBuilder.Entity<Kategori>().HasData(new Kategori
        //        {
        //            Id = Convert.ToInt32(item.Attribute("KategoriID").Value),
        //            Ad = item.Element("KategoriAd").Value,
        //        });
        //    }

        //    modelBuilder.Entity<Admin>().HasData(new Admin
        //    {
        //        Id = 1,
        //        Ad = "admin",
        //        Soyad = "admin",
        //        Cinsiyet=Cinsiyet.Kadin,
        //        DogumTarihi= new DateTime(1995, 10, 2,0,0,0),
        //        KayitTarihi=new DateTime(2023,10,2,0,0,0),
        //        Email = "admin@admin.com",
        //        Sifre = "123"
        //    });
        //    modelBuilder.ApplyConfiguration(new AdminConfig());
        //    modelBuilder.ApplyConfiguration(new AlinanBesinConfig());
        //    modelBuilder.ApplyConfiguration(new BesinConfig());
        //    modelBuilder.ApplyConfiguration(new IstekSikayetConfig());
        //    modelBuilder.ApplyConfiguration(new KategoriConfig());
        //    modelBuilder.ApplyConfiguration(new KullaniciConfig());
        //    modelBuilder.ApplyConfiguration(new KullaniciGecmisDetayConfig());
        //}
    }
}
