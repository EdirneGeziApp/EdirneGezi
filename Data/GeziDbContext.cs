using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using EdirneGeziAPI.Models;

namespace EdirneGeziAPI.Data
{
    public class GeziDbContext : DbContext
    {
        public GeziDbContext(DbContextOptions<GeziDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Place> Places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PostgreSQL'e PostGIS coğrafi eklentisini aktif etmesini söylüyoruz
            modelBuilder.HasPostgresExtension("postgis");
            
            base.OnModelCreating(modelBuilder);

            // 1. ADIM: KATEGORİLER
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tarihi Eser" },
                new Category { Id = 2, Name = "Yöresel Lezzet" },
                new Category { Id = 3, Name = "Müze" },
                new Category { Id = 4, Name = "Doğa ve Park" }
            );

            // 2. ADIM: 20 ADET EDİRNE MEKANI (Boylam, Enlem sırasıyla)
            modelBuilder.Entity<Place>().HasData(
                // İlk 10 Mekan (Merkez ve Çevresi)
                new Place { Id = 1, CategoryId = 1, Name = "Selimiye Camii", Description = "Mimar Sinan'ın ustalık eseri.", Location = new Point(26.5594, 41.6780) { SRID = 4326 } },
                new Place { Id = 2, CategoryId = 2, Name = "Tarihi Ciğerci Niyazi Usta", Description = "Meşhur Edirne tava ciğeri.", Location = new Point(26.5550, 41.6750) { SRID = 4326 } },
                new Place { Id = 3, CategoryId = 1, Name = "Meriç Köprüsü", Description = "Gün batımının harika izlendiği tarihi köprü.", Location = new Point(26.5492, 41.6633) { SRID = 4326 } },
                new Place { Id = 4, CategoryId = 3, Name = "Sağlık Müzesi (II. Bayezid Külliyesi)", Description = "Su ve müzik sesiyle şifa dağıtan tarihi mekan.", Location = new Point(26.5414, 41.6853) { SRID = 4326 } },
                new Place { Id = 5, CategoryId = 4, Name = "Söğütlük Kent Ormanı", Description = "Meriç nehri kıyısında devasa doğa parkı.", Location = new Point(26.5350, 41.6600) { SRID = 4326 } },
                new Place { Id = 6, CategoryId = 1, Name = "Eski Cami", Description = "Devasa hat yazılarıyla ünlü tarihi cami.", Location = new Point(26.5555, 41.6766) { SRID = 4326 } },
                new Place { Id = 7, CategoryId = 2, Name = "Aydın Tava Ciğer", Description = "Selimiye'nin karşısındaki efsanevi ciğerci.", Location = new Point(26.5552, 41.6760) { SRID = 4326 } },
                new Place { Id = 8, CategoryId = 3, Name = "Edirne Kent Müzesi", Description = "Şehrin binlerce yıllık tarihini anlatan müze.", Location = new Point(26.5582, 41.6789) { SRID = 4326 } },
                new Place { Id = 9, CategoryId = 1, Name = "Rüstem Paşa Kervansarayı", Description = "Mimar Sinan'ın Edirne'deki muazzam kervansarayı.", Location = new Point(26.5561, 41.6758) { SRID = 4326 } },
                new Place { Id = 10, CategoryId = 4, Name = "Sarayiçi Kırkpınar Er Meydanı", Description = "Tarihi güreşlerin yapıldığı yeşil alan.", Location = new Point(26.5588, 41.6931) { SRID = 4326 } },

                // Yeni Eklenen 10 Mekan (Karaağaç, Kıyık ve Çeşitli Lezzetler)
                new Place { Id = 11, CategoryId = 1, Name = "Üç Şerefeli Cami", Description = "Osmanlı mimarisinde yeni bir dönemi başlatan eser.", Location = new Point(26.5539, 41.6778) { SRID = 4326 } },
                new Place { Id = 12, CategoryId = 3, Name = "Şükrü Paşa Anıtı ve Balkan Savaşı Müzesi", Description = "Edirne savunmasının kahramanı Şükrü Paşa'nın anıtı.", Location = new Point(26.5645, 41.6822) { SRID = 4326 } },
                new Place { Id = 13, CategoryId = 1, Name = "Karaağaç Tarihi Tren Garı", Description = "Günümüzde Trakya Üniversitesi Güzel Sanatlar Fakültesi olan tarihi gar.", Location = new Point(26.5292, 41.6500) { SRID = 4326 } },
                new Place { Id = 14, CategoryId = 1, Name = "Lozan Anıtı ve Meydanı", Description = "Karaağaç'ta bulunan ve Lozan Barış Antlaşması'nı simgeleyen anıt.", Location = new Point(26.5285, 41.6495) { SRID = 4326 } },
                new Place { Id = 15, CategoryId = 2, Name = "Keçecizade Badem Ezmecisi", Description = "Edirne'nin meşhur tarihi badem ezmecisi.", Location = new Point(26.5540, 41.6760) { SRID = 4326 } },
                new Place { Id = 16, CategoryId = 2, Name = "Köfteci Osman", Description = "Ciğer sevmeyenler için Edirne'nin en meşhur tarihi köftecisi.", Location = new Point(26.5555, 41.6755) { SRID = 4326 } },
                new Place { Id = 17, CategoryId = 1, Name = "Edirne Büyük Sinagogu", Description = "Avrupa'nın en büyük sinagoglarından biri, restore edilmiş muhteşem yapı.", Location = new Point(26.5511, 41.6738) { SRID = 4326 } },
                new Place { Id = 18, CategoryId = 1, Name = "Sweti George Bulgar Kilisesi", Description = "Kıyık semtinde bulunan, restore edilmiş tarihi Bulgar Ortodoks kilisesi.", Location = new Point(26.5680, 41.6860) { SRID = 4326 } },
                new Place { Id = 19, CategoryId = 3, Name = "Hasan Ali Yücel Çocuk Müzesi", Description = "Balkanların en büyük çocuk ve interaktif eğitim müzesi.", Location = new Point(26.5850, 41.6620) { SRID = 4326 } },
                new Place { Id = 20, CategoryId = 1, Name = "Tunca Köprüsü", Description = "Tunca nehri üzerindeki zarif Osmanlı köprüsü.", Location = new Point(26.5525, 41.6685) { SRID = 4326 } }
            );
        }
    }
}