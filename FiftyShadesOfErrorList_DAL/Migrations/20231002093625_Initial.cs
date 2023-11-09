using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FiftyShadesOfErrorList_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    Doğum_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Vücut_Tipi = table.Column<int>(type: "int", nullable: false),
                    Egzersiz = table.Column<int>(type: "int", nullable: false),
                    GunlukAlinanKalori = table.Column<int>(type: "int", nullable: false),
                    GunlukAlinanSuMiktari = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yöneticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    Doğum_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yöneticiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    Yag = table.Column<double>(type: "float", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Besinler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcı_Geçmiş_Detaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<float>(type: "real", nullable: false),
                    Boy = table.Column<float>(type: "real", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcı_Geçmiş_Detaylar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanıcı_Geçmiş_Detaylar_Kullanıcılar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanıcılar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "İstek_Ve_Şikayetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "text", nullable: false),
                    OkunduMu = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İstek_Ve_Şikayetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_İstek_Ve_Şikayetler_Kullanıcılar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanıcılar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_İstek_Ve_Şikayetler_Yöneticiler_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Yöneticiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tüketilen_Besinler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BesinId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Tüketilen_Miktar = table.Column<double>(type: "float", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alınan_Kalori = table.Column<double>(type: "float", nullable: false),
                    Öğün = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tüketilen_Besinler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tüketilen_Besinler_Besinler_BesinId",
                        column: x => x.BesinId,
                        principalTable: "Besinler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tüketilen_Besinler_Kullanıcılar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanıcılar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Ad", "GuncellemeTarihi", "KayitTarihi", "SilmeTarihi" },
                values: new object[,]
                {
                    { 1, "Tahil Urunleri", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8423), null },
                    { 2, "Sut Urunleri", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8463), null },
                    { 3, "Meyveler", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8469), null },
                    { 4, "Sebzeler", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8475), null },
                    { 5, "Atistirmaliklar", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8481), null },
                    { 6, "Yaglar", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8488), null },
                    { 7, "Et Urunleri", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8494), null },
                    { 8, "Kumes Hayvanlari", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8499), null },
                    { 9, "Deniz Urunleri", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8504), null },
                    { 10, "Corbalar", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8510), null },
                    { 11, "Salatalar", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8516), null },
                    { 12, "Sebze Yemekleri", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8521), null },
                    { 13, "Pose Sebzeler", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8526), null },
                    { 14, "Kahvalti", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8531), null },
                    { 15, "Baklagiller", null, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(8544), null }
                });

            migrationBuilder.InsertData(
                table: "Yöneticiler",
                columns: new[] { "Id", "Ad", "Cinsiyet", "Doğum_Tarihi", "Email", "GuncellemeTarihi", "KayitTarihi", "Sifre", "SilmeTarihi", "Soyad" },
                values: new object[] { 1, "admin", 1, new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", null, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", null, "admin" });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "Id", "Ad", "Birim", "GuncellemeTarihi", "Kalori", "Karbonhidrat", "KategoriId", "KayitTarihi", "Miktar", "Porsiyon", "Protein", "ResimYolu", "SilmeTarihi", "Yag" },
                values: new object[,]
                {
                    { 1, "Tam Buğday Ekmeği", "g", null, 63.0, 1068.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(416), 25.0, "1 dilim", 311.0, null, null, 88.0 },
                    { 2, "Çavdar Ekmeği", "g", null, 65.0, 1207.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(516), 25.0, "1 dilim", 212.0, null, null, 82.0 },
                    { 3, "Tahıllı Ekmek", "g", null, 66.0, 1084.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(536), 25.0, "1 dilim", 334.0, null, null, 106.0 },
                    { 4, "Kepekli Ekmek", "g", null, 62.0, 1195.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(552), 25.0, "1 dilim", 22.0, null, null, 85.0 },
                    { 5, "Beyaz Ekmek", "g", null, 72.0, 1362.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(567), 25.0, "1 dilim", 255.0, null, null, 1.0 },
                    { 6, "Mısır Ekmeği", "g", null, 62.0, 1145.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(584), 25.0, "1 dilim", 108.0, null, null, 131.0 },
                    { 7, "Sandviç Ekmeği (Beyaz)", "g", null, 216.0, 4086.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(599), 75.0, "3 dilim beyaz ekmek", 765.0, null, null, 3.0 },
                    { 8, "Sandviç Ekmeği (Tahıllı)", "g", null, 198.0, 3252.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(613), 75.0, "3 dilim tahıllı ekmek", 1002.0, null, null, 318.0 },
                    { 9, "Simit", "g", null, 434.0, 69.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(628), 100.0, "1 adet", 1.0, null, null, 17.0 },
                    { 10, "Yulaf Gevreği (Musli)", "g", null, 141.0, 3028.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(644), 40.0, "2 yemek kaşığı", 448.0, null, null, 132.0 },
                    { 11, "Sade Mısır Gevreği (Cornﬂakes)", "g", null, 101.0, 2428.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(659), 30.0, "1 su bardağı", 188.0, null, null, 3.0 },
                    { 12, "Tam Tahıllı Gevrek", "g", null, 124.0, 274.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(679), 33.0, "1 su bardağı", 239.0, null, null, 112.0 },
                    { 13, "Yulaf Ezmesi", "g", null, 73.0, 134.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(702), 20.0, "2 yemek kaşığı", 32.0, null, null, 126.0 },
                    { 14, "Patates", "g", null, 77.0, 1749.0, 1, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(716), 100.0, "1 orta boy", 205.0, null, null, 9.0 },
                    { 15, "İnek Sütü(Tam Yaglı)", "ml", null, 110.0, 864.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(730), 200.0, "1 su bardağı", 567.0, null, null, 585.0 },
                    { 16, "İnek Sütü (Yarım Yaglı)", "ml", null, 92.0, 1084.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(744), 200.0, "1 su bardağı", 666.0, null, null, 208.0 },
                    { 17, "İnek Sütü (Yagsız)", "ml", null, 76.0, 10.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(759), 200.0, "1 su bardağı", 666.0, null, null, 1.0 },
                    { 18, "Keçi Sütü", "ml", null, 124.0, 10.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(773), 200.0, "1 su bardağı", 666.0, null, null, 666.0 },
                    { 19, "Soya Sütü", "ml", null, 112.0, 176.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(786), 200.0, "1 su bardağı", 4.0, null, null, 24.0 },
                    { 20, "Hindistan Cevizi Sütü", "ml", null, 200.0, 769.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(801), 100.0, "1 çay bardağı", 154.0, null, null, 1849.0 },
                    { 21, "Beyaz Peynir(Yarım Yaglı İnek)", "g", null, 60.0, 244.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(815), 30.0, "2 parmak kalınlığında", 235.0, null, null, 458.0 },
                    { 22, "Süzme Peynir", "g", null, 69.0, 105.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(829), 30.0, "2 parmak kalınlığında", 405.0, null, null, 54.0 },
                    { 23, "Lor Peyniri", "g", null, 43.0, 92.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(842), 50.0, "3 yemek kaşığı", 86.0, null, null, 21.0 },
                    { 24, "Light Kaşar Peyniri", "g", null, 753.0, 12.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(857), 30.0, "2 parmak kalınlığında", 915.0, null, null, 375.0 },
                    { 25, "Labne Peyniri", "g", null, 955.0, 225.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(871), 50.0, "2 yemek kaşığı", 245.0, null, null, 85.0 },
                    { 26, "Örgü Peynir", "g", null, 972.0, 45.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(884), 30.0, "2 parmak kalınlığında", 8.0, null, null, 705.0 },
                    { 27, "Dil Peyniri", "g", null, 81.0, 6.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(897), 30.0, "2 parmak kalınlığında", 678.0, null, null, 57.0 },
                    { 28, "Mozarella", "g", null, 90.0, 66.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(911), 30.0, "2 parmak kalınlığında", 661.0, null, null, 671.0 },
                    { 29, "Hellim Peyniri", "g", null, 915.0, 25.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(930), 30.0, "2 parmak kalınlığında", 713.0, null, null, 69.0 },
                    { 30, "Kefir (Yaglı)", "ml", null, 120.0, 10.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(945), 200.0, "1 su bardağı", 56.0, null, null, 6.0 },
                    { 31, "Kefir (Yagsız)", "ml", null, 74.0, 806.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(958), 200.0, "1 su bardağı", 682.0, null, null, 167.0 },
                    { 32, "Meyveli Kefir", "ml", null, 156.0, 20.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(973), 200.0, "1 su bardağı", 54.0, null, null, 6.0 },
                    { 33, "Süzme Yoğurt", "ml", null, 95.0, 45.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(986), 100.0, "1 çay bardağı", 504.0, null, null, 63.0 },
                    { 34, "Yoğurt (Yaglı)", "ml", null, 87.0, 358.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1001), 100.0, "1 çay bardağı", 81.0, null, null, 45.0 },
                    { 35, "Yoğurt (Yagsız)", "ml", null, 53.0, 324.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1014), 100.0, "1 çay bardağı", 917.0, null, null, 35.0 },
                    { 36, "Meyveli Yoğurt", "ml", null, 95.0, 1106.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1029), 100.0, "1 çay bardağı", 66.0, null, null, 27.0 },
                    { 37, "Ayran", "ml", null, 76.0, 56.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1042), 200.0, "1 su bardağı", 4.0, null, null, 4.0 },
                    { 38, "Cacık", "ml", null, 115.0, 11.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1055), 200.0, "1 su bardağı", 666.0, null, null, 486.0 },
                    { 39, "Badem Sütü", "ml", null, 48.0, 6.0, 2, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1069), 200.0, "1 su bardağı", 1.0, null, null, 22.0 },
                    { 40, "Elma", "g", null, 95.0, 2513.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1083), 182.0, "1 orta boy", 47.0, null, null, 31.0 },
                    { 41, "Armut", "g", null, 101.0, 2711.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1097), 178.0, "1 orta boy", 64.0, null, null, 25.0 },
                    { 42, "Portakal", "g", null, 62.0, 1539.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1111), 130.0, "1 orta boy", 123.0, null, null, 16.0 },
                    { 43, "Greyfurt", "g", null, 74.0, 1845.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1125), 246.0, "1 orta boy", 135.0, null, null, 25.0 },
                    { 44, "Ayva", "g", null, 57.0, 153.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1139), 100.0, "1 küçük boy", 4.0, null, null, 1.0 },
                    { 45, "Mandalina", "g", null, 40.0, 1014.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1158), 76.0, "1 küçük boy", 62.0, null, null, 24.0 },
                    { 46, "Kivi", "g", null, 42.0, 1012.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1174), 69.0, "1 orta boy", 79.0, null, null, 36.0 },
                    { 47, "Muz", "g", null, 105.0, 2695.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1187), 118.0, "1 orta boy", 129.0, null, null, 39.0 },
                    { 48, "Kayısı", "g", null, 17.0, 389.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1201), 35.0, "1 küçük boy", 49.0, null, null, 14.0 },
                    { 49, "Çilek", "g", null, 46.0, 1106.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1215), 144.0, "1 kase", 96.0, null, null, 43.0 },
                    { 50, "Trabzon hurması", "g", null, 60.0, 1596.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1228), 80.0, "1 orta boy", 48.0, null, null, 17.0 },
                    { 51, "Kiraz", "g", null, 87.0, 2209.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1242), 138.0, "1 kase", 146.0, null, null, 28.0 },
                    { 52, "Vişne", "g", null, 52.0, 1255.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1256), 103.0, "1 kase", 103.0, null, null, 31.0 },
                    { 53, "Kavun", "g", null, 54.0, 1306.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1270), 160.0, "1 kase", 134.0, null, null, 3.0 },
                    { 54, "Karpuz", "g", null, 46.0, 1163.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1283), 154.0, "1 kase", 94.0, null, null, 23.0 },
                    { 55, "Ananas", "g", null, 28.0, 735.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1297), 56.0, "1 ince dilim", 3.0, null, null, 7.0 },
                    { 56, "Avakado", "g", null, 106.0, 563.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1312), 66.0, "1/3 orta boy", 132.0, null, null, 968.0 },
                    { 57, "Mango", "g", null, 99.0, 2472.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1326), 165.0, "1 kase", 135.0, null, null, 63.0 },
                    { 58, "Ahududu", "g", null, 64.0, 1469.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1340), 123.0, "1 kase", 148.0, null, null, 8.0 },
                    { 59, "Böğürtlen", "g", null, 62.0, 1384.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1353), 144.0, "1 kase", 2.0, null, null, 71.0 },
                    { 60, "Yaban Mersini", "g", null, 84.0, 2145.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1367), 148.0, "1 kase", 11.0, null, null, 49.0 },
                    { 61, "Yeşil Erik", "g", null, 76.0, 1884.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1380), 165.0, "1 kase", 115.0, null, null, 46.0 },
                    { 62, "Kumkuat", "g", null, 13.0, 302.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1397), 13.0, "1 adet", 36.0, null, null, 16.0 },
                    { 63, "Kırmızı Erik", "g", null, 81.0, 2101.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1414), 135.0, "1 kase", 97.0, null, null, 31.0 },
                    { 64, "Yenidünya", "g", null, 70.0, 1809.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1428), 148.0, "1 kase", 64.0, null, null, 3.0 },
                    { 65, "İncir", "g", null, 37.0, 959.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1442), 50.0, "1 orta boy", 38.0, null, null, 15.0 },
                    { 66, "Dut", "g", null, 60.0, 1372.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1456), 140.0, "1 kase", 202.0, null, null, 55.0 },
                    { 67, "Üzüm", "g", null, 104.0, 2733.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1470), 151.0, "1 kase", 109.0, null, null, 24.0 },
                    { 68, "Nar", "g", null, 72.0, 1627.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1484), 87.0, "1/2 kase", 145.0, null, null, 102.0 },
                    { 69, "Şeftali", "g", null, 58.0, 1431.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1498), 150.0, "1 orta boy", 136.0, null, null, 38.0 },
                    { 70, "Limon", "g", null, 17.0, 541.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1511), 58.0, "1 orta boy", 64.0, null, null, 17.0 },
                    { 71, "Kuru İncir", "g", null, 47.0, 1214.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1524), 15.0, "1 orta boy", 63.0, null, null, 18.0 },
                    { 72, "Kuru üzüm", "g", null, 897.0, 2375.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1539), 30.0, "1.5 yemek kaşığı", 92.0, null, null, 14.0 },
                    { 73, "Kuru kayısı", "g", null, 16.0, 438.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1557), 10.0, "1 orta boy", 24.0, null, null, 4.0 },
                    { 74, "Kuru mürdüm eriği", "g", null, 20.0, 537.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1571), 10.0, "1 orta boy", 18.0, null, null, 3.0 },
                    { 75, "Kuru yaban mersini", "g", null, 91.0, 2413.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1584), 30.0, "1.5 yemek kaşığı", 12.0, null, null, 4.0 },
                    { 76, "Hurma", "g", null, 23.0, 623.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1600), 10.0, "1 orta boy", 2.0, null, null, 3.0 },
                    { 77, "Kuru dut", "g", null, 676.0, 1698.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1613), 40.0, "2 yemek kaşığı", 88.0, null, null, 36.0 },
                    { 78, "Taze Sıkılmış Meyve Suyu", "ml", null, 124.0, 295.0, 3, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1634), 200.0, "1 su bardağı", 44.0, null, null, 0.0 },
                    { 79, "Domates", "g", null, 22.0, 478.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1649), 123.0, "1 orta boy", 108.0, null, null, 25.0 },
                    { 80, "Çeri Domates", "g", null, 27.0, 58.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1664), 149.0, "1 kase", 131.0, null, null, 3.0 },
                    { 81, "Salatalık ", "g", null, 15.0, 363.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1678), 100.0, "1 orta boy", 65.0, null, null, 11.0 },
                    { 82, " Marul Kıvırcık", "g", null, 5.0, 1.03, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1691), 36.0, " 1 kase doğranmış", 0.48999999999999999, null, null, 0.050000000000000003 },
                    { 83, "Çarliston Biber", "g", null, 12.0, 246.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1709), 46.0, "1 orta boy", 76.0, null, null, 21.0 },
                    { 84, "Kırmızı Biber", "g", null, 37.0, 718.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1724), 119.0, "1 orta boy", 118.0, null, null, 36.0 },
                    { 85, "Nane", "g", null, 1.0, 24.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1737), 5.0, "1 yemek kaşığı", 6.0, null, null, 1.0 },
                    { 86, "Reyhan/Fesleğen", "g", null, 1.0, 23.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1751), 10.0, "2 yemek kaşığı", 13.0, null, null, 3.0 },
                    { 87, "Dereotu", "g", null, 1.0, 23.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1765), 10.0, "2 yemek kaşığı", 13.0, null, null, 3.0 },
                    { 88, "Kişniş", "g", null, 5.0, 99.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1779), 5.0, "1 yemek kaşığı", 22.0, null, null, 32.0 },
                    { 89, "Biberiye", "g", null, 4.0, 77.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1792), 5.0, "1 yemek kaşığı", 6.0, null, null, 18.0 },
                    { 90, "Maydanoz", "g", null, 1.0, 24.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1805), 5.0, "1 yemek kaşığı", 11.0, null, null, 3.0 },
                    { 91, "Turp", "g", null, 19.0, 394.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1818), 116.0, "1 kase doğranmış", 79.0, null, null, 12.0 },
                    { 92, "Roka", "g", null, 5.0, 73.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1831), 20.0, "1 kase", 52.0, null, null, 13.0 },
                    { 93, "Kereviz Yaprağı", "g", null, 16.0, 3.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1844), 101.0, "1 kase", 7.0, null, null, 17.0 },
                    { 94, "Karnabahar", "g", null, 27.0, 532.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1858), 107.0, "1 kase doğranmış", 205.0, null, null, 3.0 },
                    { 95, "Brokoli", "g", null, 31.0, 604.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1878), 91.0, "1 kase doğranmış", 257.0, null, null, 34.0 },
                    { 96, "Brüksel Lahanası", "g", null, 38.0, 788.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1892), 88.0, "1 kase", 297.0, null, null, 26.0 },
                    { 97, "Beyaz Lahana", "g", null, 22.0, 516.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1906), 90.0, "1 kase", 114.0, null, null, 9.0 },
                    { 98, "Kırmızı Lahana", "g", null, 28.0, 656.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1919), 90.0, "1 kase", 127.0, null, null, 14.0 },
                    { 99, "Havuç", "g", null, 25.0, 584.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1932), 61.0, "1 orta boy", 57.0, null, null, 15.0 },
                    { 100, "Sarımsak", "g", null, 4.0, 99.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1947), 5.0, "1 diş", 19.0, null, null, 2.0 },
                    { 101, "Soğan", "g", null, 44.0, 1027.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1961), 110.0, "1 orta boy", 121.0, null, null, 11.0 },
                    { 102, "Yeşil Soğan", "g", null, 2.0, 44.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1975), 5.0, "1 yemek kaşığı kıyılmış", 11.0, null, null, 1.0 },
                    { 103, "Semizotu", "g", null, 9.0, 146.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(1989), 43.0, "1 kase", 87.0, null, null, 15.0 },
                    { 104, "Pazı", "g", null, 7.0, 135.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2005), 36.0, "1 kase", 65.0, null, null, 7.0 },
                    { 105, "Kabak", "g", null, 33.0, 61.0, 4, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2019), 196.0, "1 orta boy", 237.0, null, null, 63.0 },
                    { 106, "Kestane (Haşlama veya Izgara)", "g", null, 98.0, 2209.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2032), 50.0, "1/2 kase", 81.0, null, null, 62.0 },
                    { 107, "Patlamış Mısır (Yagsız/Tuzsuz)", "g", null, 76.0, 1558.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2046), 20.0, "1 su bardağı", 24.0, null, null, 84.0 },
                    { 108, "Sarı Leblebi", "g", null, 71.0, 117.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2060), 20.0, "1 çay bardağı", 373.0, null, null, 125.0 },
                    { 109, "Beyaz Leblebi", "g", null, 72.0, 119.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2074), 20.0, "1 çay bardağı", 379.0, null, null, 12.0 },
                    { 110, "Fındık", "g", null, 97.0, 257.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2087), 15.0, "10-12 adet", 23.0, null, null, 936.0 },
                    { 111, "Badem", "g", null, 97.0, 362.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2101), 17.0, "12-14 adet", 355.0, null, null, 839.0 },
                    { 112, "Ceviz", "g", null, 52.0, 11.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2118), 10.0, "1 tam adet", 122.0, null, null, 522.0 },
                    { 113, "Kabak Çekirdeği", "g", null, 1044.0, 268.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2134), 20.0, "2 yemek kaşığı", 66.0, null, null, 842.0 },
                    { 114, "Çiğ Kaju", "g", null, 111.0, 604.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2148), 20.0, "1 yemek kaşığı", 364.0, null, null, 877.0 },
                    { 115, "Galeta", "g", null, 32.0, 52.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2161), 7.0, "1 adet", 66.0, null, null, 76.0 },
                    { 116, "Grissini", "g", null, 22.0, 38.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2175), 6.0, "1 adet", 52.0, null, null, 48.0 },
                    { 117, "Grissini(ince)", "g", null, 22.0, 38.0, 5, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2188), 6.0, "2 adet", 52.0, null, null, 48.0 },
                    { 118, "Köfte", "g", null, 59.0, 24.0, 7, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2201), 30.0, "1 yumurta kadar ", 63.0, null, null, 27.0 },
                    { 119, "Biftek", "g", null, 756.0, 0.0, 7, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2215), 30.0, " 1 yumurta kadar", 82.0, null, null, 45.0 },
                    { 120, "Dana Antrikot ", "g", null, 82.0, 0.0, 7, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2229), 50.0, "1.5 yumurta kadar", 10.73, null, null, 4.0999999999999996 },
                    { 121, "Dana Kuşbaşı", "g", null, 651.0, 0.0, 7, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2244), 30.0, "1 yumurta kadar", 744.0, null, null, 37.0 },
                    { 122, "Yagsız Koyun Eti", "g", null, 70.0, 2.0, 7, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2258), 30.0, "1 yumurta kadar", 1003.0, null, null, 333.0 },
                    { 123, "Tavşan ", "g", null, 68.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2272), 50.0, "1.5 yumurta kadar ", 10.029999999999999, null, null, 2.77 },
                    { 124, "Hindi (Göğüs)", "g", null, 63.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2288), 50.0, "1.5 yumurta kadar", 1108.0, null, null, 173.0 },
                    { 125, "Hindi (But)", "g", null, 62.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2301), 30.0, "1 yumurta kadar", 836.0, null, null, 295.0 },
                    { 126, " Tavuk (Göğüs)", "g", null, 76.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2314), 50.0, " 1.5 yumurta kadar", 15.27, null, null, 1.5800000000000001 },
                    { 127, "Tavuk (But)", "g", null, 66.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2328), 30.0, "1 yumurta kadar", 725.0, null, null, 388.0 },
                    { 128, "Tavuk (Kanat)", "g", null, 61.0, 0.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2342), 30.0, "1 yumurta kadar", 914.0, null, null, 244.0 },
                    { 129, "Yumurta (Haşlanmış)", "g", null, 70.0, 5.0, 8, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2359), 45.0, "1 orta boy", 566.0, null, null, 477.0 },
                    { 130, "Somon", "g", null, 76.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2377), 50.0, "1.5 yumurta kadar", 1229.0, null, null, 264.0 },
                    { 131, "Somon (Füme)", "g", null, 103.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2391), 50.0, "1.5 yumurta kadar", 1759.0, null, null, 363.0 },
                    { 132, "Light Ton Balığı", "g", null, 86.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2408), 100.0, "3 yumurta kadar", 1944.0, null, null, 96.0 },
                    { 133, "Alabalık", "g", null, 119.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2422), 71.0, "2.5 yumurta kadar", 169.0, null, null, 524.0 },
                    { 134, "Istakoz", "g", null, 129.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2435), 145.0, " 1 kase pişmiş", 2755.0, null, null, 125.0 },
                    { 135, "Levrek ", "g", null, 125.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2448), 101.0, "3 yumurta kadar ", 2387.0, null, null, 259.0 },
                    { 136, "Çupra ", "g", null, 120.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2462), 110.0, "3.5 yumurta kadar", 21.710000000000001, null, null, 3.0 },
                    { 137, "Karides", "g", null, 128.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2477), 128.0, "1 kase pişmiş", 2614.0, null, null, 174.0 },
                    { 138, "Sazan ", "g", null, 138.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2491), 85.0, "3 yumurta kadar", 1943.0, null, null, 609.0 },
                    { 139, " Mezgit", "g", null, 99.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2504), 85.0, "3 yumurta kadar ", 19.960000000000001, null, null, 1.4399999999999999 },
                    { 140, "İstavrit", "g", null, 156.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2520), 85.0, "3 yumurta kadar", 2542.0, null, null, 534.0 },
                    { 141, "Hamsi", "g", null, 42.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2534), 20.0, "5 adet", 578.0, null, null, 194.0 },
                    { 142, "Palamut", "g", null, 231.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2550), 90.0, "3 yumurta kadar", 2099.0, null, null, 1567.0 },
                    { 143, "Barbun", "g", null, 128.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2568), 85.0, "3 yumurta kadar", 2109.0, null, null, 413.0 },
                    { 144, "Kalkan", "g", null, 104.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2581), 85.0, "3 yumurta kadar", 1749.0, null, null, 321.0 },
                    { 145, "Fener", "g", null, 82.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2594), 85.0, "3 yumurta kadar", 1578.0, null, null, 166.0 },
                    { 146, "Ahtapot", "g", null, 139.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2607), 85.0, "3 yumurta kadar", 2535.0, null, null, 177.0 },
                    { 147, "Dil Balığı", "g", null, 73.0, 0.0, 9, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2619), 85.0, "3 yumurta kadar", 1295.0, null, null, 201.0 },
                    { 148, "Mercimek Çorbası", "g", null, 99.0, 963.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2701), 180.0, "1 su bardağı/1 kepçe", 361.0, null, null, 52.0 },
                    { 149, "Tavuk Çorbası", "g", null, 56.0, 7.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2737), 180.0, "1 su bardağı/1 kepçe", 302.0, null, null, 183.0 },
                    { 150, "Tarhana Çorbası ", "g", null, 1476.0, 265.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2752), 180.0, "1 su bardağı/1 kepçe ", 441.0, null, null, 252.0 },
                    { 151, "Sebze Çorbası ", "g", null, 59.0, 10.91, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2768), 180.0, "1 su bardağı/1 kepçe 1 ", 1.98, null, null, 0.81000000000000005 },
                    { 152, "Ezogelin Çorbası", "g", null, 936.0, 1683.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2784), 180.0, "su bardağı/1 kepçe 1", 621.0, null, null, 3.0 },
                    { 153, "Yayla Çorbası ", "g", null, 117.0, 943.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2799), 180.0, "su bardağı/1 kepçe 1", 329.0, null, null, 738.0 },
                    { 154, "Balkabağı Çorbası ", "g", null, 53.0, 81.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2813), 180.0, "su bardağı/1 kepçe 1", 185.0, null, null, 183.0 },
                    { 155, "Mantar çorbası", "g", null, 123.0, 1032.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2827), 180.0, "su bardağı/1 kepçe", 44.0, null, null, 715.0 },
                    { 156, "Brokoli Çorbası", "g", null, 156.0, 136.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2841), 180.0, "1 su bardağı/1 kepçe", 619.0, null, null, 903.0 },
                    { 157, "Lahana Çorbası", "g", null, 53.0, 565.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2856), 180.0, "1 su bardağı/1 kepçe", 288.0, null, null, 239.0 },
                    { 158, "Domates Çorbası", "g", null, 68.0, 1291.0, 10, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2869), 180.0, "1 su bardağı/1 kepçe", 167.0, null, null, 11.0 },
                    { 159, "Sade Salata(karışık yeşillik)", "g", null, 9.0, 176.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2883), 55.0, "1 kase doğranmış", 84.0, null, null, 13.0 },
                    { 160, "Mercimekli Lor Peynirli Salata", "g", null, 180.0, 28.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2903), 255.0, "1 porsiyon", 27.0, null, null, 51.0 },
                    { 161, "Tavuklu Salata", "g", null, 225.0, 528.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2917), 255.0, "1 porsiyon", 3138.0, null, null, 829.0 },
                    { 162, "Etli Salata", "g", null, 267.0, 528.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2931), 260.0, "1 porsiyon", 2484.0, null, null, 1649.0 },
                    { 163, "Ton Balıklı Salata", "g", null, 215.0, 528.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2948), 270.0, "1 porsiyon", 2196.0, null, null, 635.0 },
                    { 164, "Kısır", "g", null, 108.0, 1584.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2962), 60.0, "4 yemek kaşığı", 271.0, null, null, 464.0 },
                    { 165, "Mercimek Köftesi", "g", null, 70.0, 995.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2975), 30.0, "2 yemek kaşığı", 275.0, null, null, 241.0 },
                    { 166, "Tabule Salatası", "g", null, 588.0, 51.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(2989), 370.0, "1 porsiyon", 144.0, null, null, 333.0 },
                    { 167, "Lor Peynirli Yumurtalı Salata", "g", null, 225.0, 67.0, 11, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3004), 260.0, "1 porsiyon", 1678.0, null, null, 981.0 },
                    { 168, "Ispanak Yemeği (Pirinçli veya Bulgurlu)", "g", null, 115.0, 509.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3017), 100.0, "5 yemek kaşığı", 211.0, null, null, 103.0 },
                    { 169, "Ispanak Yemeği (Etli,Kıymalı,Yumurtalı)", "g", null, 1445.0, 629.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3031), 130.0, "6 yemek kaşığı", 526.0, null, null, 1165.0 },
                    { 170, "ZeytinYaglı Semizotu (Pirinçli veya Bulgurlu)", "g", null, 112.0, 498.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3045), 100.0, "5 yemek kaşığı", 129.0, null, null, 1026.0 },
                    { 171, "Semizotu Yemeği (Etli veya Kıymalı)", "g", null, 1415.0, 618.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3060), 130.0, "6 yemek kaşığı", 444.0, null, null, 1100.0 },
                    { 172, "ZeytinYaglı Pazı (Pirinçli veya Bulgurlu)", "g", null, 131.0, 1189.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3074), 100.0, "5 yemek kaşığı", 374.0, null, null, 718.0 },
                    { 173, "Pazı Yemeği (Etli veya Kıymalı)", "g", null, 160.0, 1309.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3088), 130.0, "6 yemek kaşığı", 689.0, null, null, 853.0 },
                    { 174, "ZeytinYaglı Taze Fasülye", "g", null, 151.0, 2139.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3103), 100.0, "5 yemek kaşığı", 554.0, null, null, 515.0 },
                    { 175, "Taze Fasulye Yemeği (Etli veya Kıymalı)", "g", null, 1805.0, 2259.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3116), 130.0, "6 yemek kaşığı", 869.0, null, null, 65.0 },
                    { 176, "ZeytinYaglı Pırasa(Pirinçli ya da Nohutlu)", "g", null, 120.0, 725.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3130), 100.0, "5 yemek kaşığı", 91.0, null, null, 1027.0 },
                    { 177, "Bezelye Yemeği (Havuçlu)", "g", null, 147.0, 1107.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3148), 100.0, "5 yemek kaşığı", 348.0, null, null, 1038.0 },
                    { 178, "Bezelye Yemeği (Etli/Tavuklu/Kıymalı)", "g", null, 1765.0, 1227.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3165), 130.0, "6 yemek kaşığı", 663.0, null, null, 1173.0 },
                    { 179, "ZeytinYaglı Brokoli", "g", null, 80.0, 714.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3180), 100.0, "5 yemek kaşığı", 237.0, null, null, 541.0 },
                    { 180, "Brokoli Yemeği (Etli/Kıymalı)", "g", null, 110.0, 834.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3193), 130.0, "6 yemek kaşığı", 552.0, null, null, 676.0 },
                    { 181, "Karnabahar Yemeği", "g", null, 115.0, 529.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3207), 100.0, "5 yemek kaşığı", 148.0, null, null, 1041.0 },
                    { 182, "Karnabahar Yemeği (Etli/Tavuklu/Kıymalı)", "g", null, 1445.0, 645.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3221), 130.0, "6 yemek kaşığı", 463.0, null, null, 1176.0 },
                    { 183, "Bamya Yemeği", "g", null, 113.0, 468.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3235), 100.0, "5 yemek kaşığı", 106.0, null, null, 1057.0 },
                    { 184, "Bamya Yemeği (Etli/Kıymalı)", "g", null, 1425.0, 588.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3249), 130.0, "6 yemek kaşığı", 421.0, null, null, 1192.0 },
                    { 185, "ZeytinYaglı Türlü", "g", null, 112.0, 868.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3263), 100.0, "5 yemek kaşığı", 133.0, null, null, 887.0 },
                    { 186, "Etli Türlü Yemeği", "g", null, 1415.0, 988.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3277), 130.0, "6 yemek kaşığı", 448.0, null, null, 1022.0 },
                    { 187, "ZeytinYaglı Bakla", "g", null, 145.0, 976.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3291), 100.0, "5 yemek kaşığı", 332.0, null, null, 1069.0 },
                    { 188, "ZeytinYaglı Kereviz", "g", null, 90.0, 714.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3304), 100.0, "5 yemek kaşığı", 192.0, null, null, 637.0 },
                    { 189, "ZeytinYaglı Enginar", "g", null, 146.0, 1209.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3318), 100.0, "5 yemek kaşığı", 293.0, null, null, 1071.0 },
                    { 190, "Mantar sote (Etli/Tavuklu)", "g", null, 118.0, 595.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3331), 130.0, "5 yemek kaşığı", 167.0, null, null, 1042.0 },
                    { 191, "Sebze Sote (Havuç,Yeşil kabak,brokoli)", "g", null, 90.0, 455.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3344), 200.0, "10 yemek kaşığı", 94.0, null, null, 1019.0 },
                    { 192, "ZeytinYaglı Sebze Dolması", "g", null, 258.0, 1359.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3358), 200.0, "1 kase kadar", 56.0, null, null, 1359.0 },
                    { 193, "ZeytinYaglı yaprak Sarma", "g", null, 108.0, 832.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3371), 60.0, "3 adet", 133.0, null, null, 815.0 },
                    { 194, "Etli Sebze Dolması", "g", null, 358.0, 83.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3389), 200.0, "1 kase kadar", 1867.0, null, null, 2817.0 },
                    { 195, "Etli Yaprak Sarma", "g", null, 176.0, 1124.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3404), 100.0, "5-6 adet", 623.0, null, null, 1232.0 },
                    { 196, "ZeytinYaglı Kabak", "g", null, 111.0, 519.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3417), 100.0, "5 yemek kaşığı", 81.0, null, null, 1018.0 },
                    { 197, "Kabak Yemeği(Etli/Kıymalı)", "g", null, 1405.0, 639.0, 12, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3431), 130.0, "6 yemek kaşığı", 396.0, null, null, 1153.0 },
                    { 198, "Yeşil Kabak", "g", null, 15.0, 269.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3445), 100.0, "1 küçük boy", 114.0, null, null, 36.0 },
                    { 199, "Ispanak", "g", null, 7.0, 109.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3458), 180.0, "1 kase haşlanmış", 86.0, null, null, 12.0 },
                    { 200, "Semizotu", "g", null, 7.0, 147.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3472), 180.0, "1 kase haşlanmış", 56.0, null, null, 4.0 },
                    { 201, "Pazı", "g", null, 39.0, 789.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3490), 144.0, "1 kase kıyılmış", 37.0, null, null, 28.0 },
                    { 202, "Karnabahar", "g", null, 29.0, 51.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3503), 124.0, "1 kase haşlanmış", 228.0, null, null, 56.0 },
                    { 203, "Brokoli", "g", null, 55.0, 112.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3517), 156.0, "1 kase haşlanmış", 371.0, null, null, 64.0 },
                    { 204, "Brüksel Lahanası", "g", null, 56.0, 1108.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3530), 156.0, "1 kase haşlanmış", 398.0, null, null, 78.0 },
                    { 205, "Taze Fasülye", "g", null, 44.0, 985.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3544), 125.0, "1 kase haşlanmış", 236.0, null, null, 35.0 },
                    { 206, "Havuç", "g", null, 55.0, 1282.0, 13, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3557), 156.0, "1 kase haşlanmış", 119.0, null, null, 28.0 },
                    { 207, "Peynirli omlet", "g", null, 254.0, 205.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3571), 130.0, "2 yumurta + 1 peynir", 1537.0, null, null, 149.0 },
                    { 208, "Mantarlı omlet", "g", null, 205.0, 369.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3585), 150.0, "2 yumurta", 1246.0, null, null, 99.0 },
                    { 209, "Menemen", "g", null, 205.0, 369.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3599), 150.0, "2 yumurta", 1246.0, null, null, 99.0 },
                    { 210, "Kaşarlı omlet", "g", null, 2603.0, 22.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3612), 130.0, "2 yumurta + 1 kaşar", 2027.0, null, null, 1329.0 },
                    { 211, "Sebzeli omlet", "g", null, 205.0, 369.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3626), 150.0, "2 yumurta", 1246.0, null, null, 99.0 },
                    { 212, "Yulaﬂı omlet", "g", null, 258.0, 144.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3646), 120.0, "2 yumurta + 2 y.k yulaf ezmesi", 1452.0, null, null, 108.0 },
                    { 213, "Omlet Sade", "g", null, 185.0, 1.0, 14, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3660), 95.0, "2 yumurta", 1132.0, null, null, 149.0 },
                    { 214, "Mercimek Yemeği", "g", null, 1002.0, 854.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3674), 60.0, "3 yemek kaşığı", 329.0, null, null, 622.0 },
                    { 215, "Mercimek Yemeği(Etli/Kıymalı)", "g", null, 160.0, 1094.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3688), 90.0, "4 yemek kaşığı", 959.0, null, null, 892.0 },
                    { 216, "Nohut Yemeği", "g", null, 1014.0, 937.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3702), 60.0, "3 yemek kaşığı", 193.0, null, null, 647.0 },
                    { 217, "Nohut Yemeği(Etli/Kıymalı)", "g", null, 1604.0, 1177.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3716), 90.0, "4 yemek kaşığı", 823.0, null, null, 917.0 },
                    { 218, "Kuru Fasülye Yemeği", "g", null, 1014.0, 937.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3730), 60.0, "3 yemek kaşığı", 193.0, null, null, 647.0 },
                    { 219, "Kuru Fasülye Yemeği (Etli/Kıymalı)", "g", null, 1604.0, 1177.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3744), 90.0, "4 yemek kaşığı", 823.0, null, null, 917.0 },
                    { 220, "Bulgur Pilavı", "g", null, 80.0, 1343.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3757), 60.0, "3 yemek kaşığı", 22.0, null, null, 157.0 },
                    { 221, "Bulgur Pilavı (Sebzeli)", "g", null, 108.0, 1893.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3771), 90.0, "4 yemek kaşığı", 325.0, null, null, 207.0 },
                    { 222, "Pirinç Pilavı", "g", null, 75.0, 1294.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3785), 60.0, "3 yemek kaşığı", 124.0, null, null, 194.0 },
                    { 223, "Pirinç Pilavı(Sebzeli)", "g", null, 103.0, 1844.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3799), 90.0, "4 yemek kaşığı", 229.0, null, null, 244.0 },
                    { 224, "Şehriye Pilavı", "g", null, 774.0, 1467.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3812), 60.0, "3 yemek kaşığı", 2.0, null, null, 196.0 },
                    { 225, "Makarna (Haşlama ve Yagsız)", "g", null, 744.0, 1507.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3825), 60.0, "3 yemek kaşığı", 262.0, null, null, 58.0 },
                    { 226, "Makarna (Kıymalı)", "g", null, 1334.0, 1747.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3839), 90.0, "4 yemek kaşığı", 892.0, null, null, 328.0 },
                    { 227, "Makarna(Peynirli)", "g", null, 1174.0, 1599.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3852), 90.0, "4 yemek kaşığı", 1122.0, null, null, 79.0 },
                    { 228, "ZeytinYaglı Barbunya", "g", null, 1014.0, 937.0, 15, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3867), 60.0, "3 yemek kaşığı", 193.0, null, null, 647.0 },
                    { 229, "ZeytinYagı", "g", null, 45.0, 0.0, 6, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3886), 5.0, "1 tatlı kaşığı", 0.0, null, null, 5.0 },
                    { 230, "Fındık Yagı", "g", null, 45.0, 0.0, 6, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3900), 5.0, "1 tatlı kaşığı", 0.0, null, null, 5.0 },
                    { 231, "Ceviz Yagı", "g", null, 45.0, 0.0, 6, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3913), 5.0, "1 tatlı kaşığı", 0.0, null, null, 5.0 },
                    { 232, "TereYag", "g", null, 36.0, 0.0, 6, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3925), 5.0, "1 tatlı kaşığı", 4.0, null, null, 406.0 },
                    { 233, "Zeytin (Yeşil/Siyah)", "g", null, 45.0, 248.0, 6, new DateTime(2023, 10, 2, 12, 36, 25, 598, DateTimeKind.Local).AddTicks(3939), 40.0, "4-5 adet", 33.0, null, null, 423.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KategoriId",
                table: "Besinler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_İstek_Ve_Şikayetler_AdminId",
                table: "İstek_Ve_Şikayetler",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_İstek_Ve_Şikayetler_KullaniciId",
                table: "İstek_Ve_Şikayetler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcı_Geçmiş_Detaylar_KullaniciId",
                table: "Kullanıcı_Geçmiş_Detaylar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_Email",
                table: "Kullanıcılar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tüketilen_Besinler_BesinId",
                table: "Tüketilen_Besinler",
                column: "BesinId");

            migrationBuilder.CreateIndex(
                name: "IX_Tüketilen_Besinler_KullaniciId",
                table: "Tüketilen_Besinler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yöneticiler_Email",
                table: "Yöneticiler",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İstek_Ve_Şikayetler");

            migrationBuilder.DropTable(
                name: "Kullanıcı_Geçmiş_Detaylar");

            migrationBuilder.DropTable(
                name: "Tüketilen_Besinler");

            migrationBuilder.DropTable(
                name: "Yöneticiler");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
