using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class YeniVerilerEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Eski Camii");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Üç Şerefeli Camii");

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 21, 1, "Edirne'nin ilk elektrik üretim merkezi olan, günümüzde kültür merkezi olarak kullanılan tarihi yapı.", "https://www.edirne.bel.tr/wp-content/uploads/2019/12/elektrik-fabrikasi.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5505 41.6708)"), "Tarihi Elektrik Fabrikası" },
                    { 22, 3, "Edirne Belediye Binası içinde yer alan, Atatürk'ün şehre gelişinde konakladığı ve şahsi eşyalarının sergilendiği müze oda.", "https://www.edirne.bel.tr/wp-content/uploads/2019/12/ataturk-odasi.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5564 41.6766)"), "Atatürk Odası" },
                    { 23, 3, "Fatih Sultan Mehmet'in eğitim gördüğü Saatli Medrese'de kurulan, padişahın hayatını ve İstanbul'un fethini anlatan tematik müze.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/fatih-muzesi/IMG_2056.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5532 41.6784)"), "Fatih Sultan Mehmet Müzesi" },
                    { 24, 3, "Edirne'nin ilk özel sanat müzesi olan, içerisinde geniş resim koleksiyonları ve etnografik eserler barındıran kültür merkezi.", "https://osmanincimuzesi.com/wp-content/uploads/2021/04/muze-binasi.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5458 41.6742)"), "Osman İnci Müzesi" },
                    { 25, 3, "Selimiye Camii külliyesi içerisindeki tarihi medresede bulunan, vakıf eserlerinin ve el yazmalarının sergilendiği müze.", "https://muze.gov.tr/s3/MysFileManagement/KullaniciDosyalari/BasinBulteni/44e47f20-80d4-478a-853f-7607730e704e.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5605 41.6785)"), "Selimiye Vakıf Müzesi" },
                    { 26, 3, "Selimiye Camii arkasında yer alan, antik çağlardan günümüze arkeolojik ve etnografik eserlerin sergilendiği şehrin ana müzesi.", "https://muze.gov.tr/s3/MysFileManagement/KullaniciDosyalari/BasinBulteni/8b965825-c94a-4710-8b98-639a6742a033.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5585 41.679)"), "Edirne Müzesi" },
                    { 27, 3, "Selimiye Camii avlusunda yer alan, Osmanlı dönemine ait hat, çini, ahşap ve el yazması nadide eserlerin sergilendiği müze.", "https://muze.gov.tr/s3/MysFileManagement/KullaniciDosyalari/BasinBulteni/44e47f20-80d4-478a-853f-7607730e704e.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5595 41.6782)"), "Türk İslam Eserleri Müzesi" },
                    { 28, 3, "Balkan Savaşları'nın geçtiği tarihi Hıdırlık Tabya'da kurulan, Edirne'nin savunmasını ve Balkan tarihini canlandırmalarla sunan müze.", "https://muze.gov.tr/s3/MysFileManagement/KullaniciDosyalari/BasinBulteni/1d50c766-0749-410e-8566-60913c513e4b.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5415 41.685)"), "Balkan Tarihi Müzesi" },
                    { 29, 3, "Edirne'nin geleneksel konak mimarisini yansıtan, içerisinde şehre özgü etnografik eserlerin ve eski yaşam kültürünün sergilendiği müze.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/TEMMUZ/09/necmi-ige-evi/WhatsApp-Image-2021_07_09-at-13_34_30.jpeg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5555 41.6738)"), "Necmi İge Evi Etnografya Müzesi" },
                    { 30, 3, "Tarihi kervansaray içerisinde yer alan, geleneksel el sanatlarından modern sergilere kadar pek çok tematik müzeye ev sahipliği yapan kültür kompleksi.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/ekmekcizade/IMG_2050.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5512 41.6735)"), "Ekmekçizade Kervansarayı Müzeleri" },
                    { 31, 3, "Dünyaca ünlü heykeltıraş İlhan Koman'ın anısını yaşatan, tarihi Karaağaç Tren Garı yerleşkesinde bulunan modern sanat ve heykel müzesi.", "https://trakya.edu.tr/assets/images/content/haberler/icerik/612762a4-c79a-4712-9c17-48f0766d03f5.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5252 41.6515)"), "İlhan Koman Heykel ve Resim Müzesi" },
                    { 32, 3, "Trakya Bölgesi'ne ait bitki ve hayvan türlerinin, fosillerin ve jeolojik materyallerin sergilendiği, üniversite bünyesindeki bilimsel müze.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2023/OCAK/06/Doga-Tarihi-Muzesi/Doga-Tarihi-Muzesi_1.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5258 41.652)"), "Doğa Tarihi Müzesi" },
                    { 33, 3, "Karaağaç'ta tarihi gar binası yanında yer alan, Türkiye Cumhuriyeti'nin kuruluş belgeleri ve Milli Mücadele dönemine ait objelerin sergilendiği müze.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/lozan-muzesi/IMG_2062.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5248 41.6512)"), "Milli Mücadele ve Lozan Müzesi" },
                    { 34, 1, "II. Murad tarafından Tunca Nehri kıyısında yaptırılan, haziresinde Osmanlı şehzadelerinin kabirlerini barındıran tarihi cami.", "https://upload.wikimedia.org/wikipedia/commons/4/4b/Dar%C3%BCl_Hadis_Camii_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5492 41.6685)"), "Dar-ül Hadis Camii" },
                    { 35, 1, "Bizans sınırında görev yapan akıncı beyi Gazi Mihal tarafından Tunca Nehri kıyısında yaptırılan, erken dönem Osmanlı mimarisinin önemli örneklerinden biri.", "https://upload.wikimedia.org/wikipedia/commons/4/4e/Gazi_Mihal_Mosque_in_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5412 41.6745)"), "Gazi Mihal Camii" },
                    { 36, 1, "Defterdar Mahmut Paşa tarafından Mimar Sinan'a yaptırılan, özgün mimarisi ve merkezi konumuyla dikkat çeken Osmanlı dönemi camii.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Defterdar_Mahmut_Pasa_Camii.jpg/1024px-Defterdar_Mahmut_Pasa_Camii.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5515 41.6758)"), "Defterdar Camii" },
                    { 37, 1, "Fatih Sultan Mehmet'in eşi Sittişah Hatun tarafından yaptırılan, Edirne'deki erken Osmanlı mimarisinin ve tek kubbeli yapı tipinin en zarif örneklerinden biri.", "https://upload.wikimedia.org/wikipedia/commons/4/4b/Sittisah_Sultan_Mosque_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5498 41.6732)"), "Sittişah Sultan Camii" },
                    { 38, 1, "Edirne'nin Kaleiçi semtinde bulunan, 19. yüzyılda İtalyan topluluğu tarafından inşa edilen ve şehrin çok kültürlü mirasını yansıtan tarihi kilise.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/italyan-kilisesi/IMG_2068.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.551 41.6748)"), "İtalyan Katolik Kilisesi" },
                    { 39, 2, "Mimar Sinan tarafından Hersekli Semiz Ali Paşa adına inşa edilen, içinde çok sayıda dükkan barındıran ve günümüzde de Edirne ticaretinin kalbi olan tarihi kapalı çarşı.", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Ali_Pasha_Bazaar_Edirne_1.jpg/1024px-Ali_Pasha_Bazaar_Edirne_1.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5542 41.6765)"), "Ali Paşa Çarşısı" },
                    { 40, 2, "Selimiye Camii'ne gelir sağlamak amacıyla Mimar Sinan tarafından inşa edilen, caminin hemen altında yer alan tarihi ve otantik kapalı çarşı.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Arasta_Bazaar_Edirne.jpg/1024px-Arasta_Bazaar_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5598 41.678)"), "Arasta Çarşısı" },
                    { 41, 2, "Eski Camii'ye vakıf olarak Çelebi Mehmet tarafından yaptırılan, Edirne'nin en eski kapalı çarşısı olan ve kilitli kemerleriyle ünlü tarihi ticaret merkezi.", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Bedesten_Bazaar_Edirne.jpg/1024px-Bedesten_Bazaar_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5572 41.6768)"), "Bedesten Çarşısı" },
                    { 42, 3, "Fatih Sultan Mehmet dönemine tarihlenen ve yan yana bulunan bu iki tarihi yapı, Osmanlı eğitim sisteminin önemli merkezlerindendir; Saatli Medrese günümüzde Fatih Sultan Mehmet Müzesi olarak hizmet vermektedir.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/fatih-muzesi/IMG_2056.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5528 41.6782)"), "Peykler ve Saatli Medrese" },
                    { 43, 1, "Sultan II. Murad'ın beylerbeyi Sinan Paşa tarafından Tunca Nehri yakınlarında yaptırılan, Edirne'deki tek minareli ve erken dönem Osmanlı mimarisinin özgün detaylarını taşıyan tarihi cami.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Beylerbeyi_Mosque_in_Edirne.jpg/1024px-Beylerbeyi_Mosque_in_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5455 41.6785)"), "Beylerbeyi Camii" },
                    { 44, 4, "Beylerbeyi Camii ile aynı dönemde inşa edilen, Osmanlı hamam mimarisinin klasik özelliklerini taşıyan ve günümüzde de kullanılan tarihi hamam.", "https://www.edirnekulturturizm.gov.tr/resim/304245,beylerbeyihamami-edirnejpg.png?0", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5458 41.6782)"), "Beylerbeyi Hamamı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Eski Cami");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Üç Şerefeli Cami");
        }
    }
}
