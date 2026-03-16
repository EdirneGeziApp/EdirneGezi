using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class YeniVeri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Fatih Sultan Mehmet dönemine tarihlenen ve yan yana bulunan bu iki tarihi yapı, Osmanlı eğitim sisteminin önemli merkezlerindendir.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Sultan II. Murad'ın beylerbeyi Sinan Paşa tarafından yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Osmanlı hamam mimarisinin klasik özelliklerini taşıyan tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Osmanlı döneminde konaklama merkezi olarak kullanılan tarihi yapı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Zemin seviyesinden aşağıda olduğu için 'Çukur Hamam' olarak da bilinen tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "15. yüzyıl çinileri ve hat sanatıyla ünlü tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Sultan II. Murad döneminde inşa edilen tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Mimar Sinan tarafından Sokollu Mehmet Paşa adına inşa edilen görkemli hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "Kaleiçi semtinde yer alan tarihi hamam yapısı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Baharın gelişini simgeleyen asırlık Roman geleneği.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Dünyanın en eski spor organizasyonlarından biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Yerel tohumların korunması amacıyla düzenlenen etkinlik.");

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 54, 1, "Karaağaç mevkisinde, 15. yüzyıl Erken Osmanlı dönemine ait almaşık duvar yapısıyla dikkat çeken tarihi cami.", "https://upload.wikimedia.org/wikipedia/commons/2/23/Timurtaş_Paşa_Camii.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5386 41.6444)"), "Timurtaş Camii" },
                    { 55, 1, "Sarayiçi bölgesinde bulunan, Edirne'nin fethi sırasında şehit düştüğüne inanılan Hıdır Baba'ya ait, özellikle Kakava döneminde ziyaret edilen tarihi türbe.", "https://www.edirnekulturturizm.gov.tr/resim/hidir-baba.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.558 41.6915)"), "Hıdır Baba Türbesi" },
                    { 56, 1, "Fatih Sultan Mehmet'in kuşçubaşısı Doğan Bey tarafından yaptırılan, özgün minaresi ve erken Osmanlı dönemi mimarisiyle bilinen tarihi cami.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Kuscu_Dogan_Camii_Edirne.jpg/1024px-Kuscu_Dogan_Camii_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5512 41.6815)"), "Kuşçu Doğan Camii" },
                    { 57, 1, "Edirne'nin tarihi mahallelerinden birine adını veren, klasik Osmanlı mimarisini yansıtan ve mahalle kültürünün merkezinde yer alan tarihi cami.", "https://www.edirnekulturturizm.gov.tr/resim/hidiragacamii-edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.562 41.6815)"), "Hıdıraga Camii" },
                    { 58, 1, "Çelebi Sultan Mehmed'in kızı Selçuk Hatun tarafından 15. yüzyılda yaptırılan, Edirne'nin tarihi dokusunu yansıtan zarif ve butik bir Osmanlı camisi.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Selcuk_Hatun_Mosque_Edirne.jpg/1024px-Selcuk_Hatun_Mosque_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5562 41.6738)"), "Selçuk Hatun Camii" },
                    { 59, 1, "15. yüzyılda Kasımpaşa tarafından Tunca Nehri kıyısında yaptırılan, nehir taşkınlarına karşı koruma amacıyla inşa edilen rıhtımı ve haziresindeki Evliya Kasımpaşa'nın türbesiyle bilinen tarihi yapı.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Evliya_Kasim_Pasha_Mosque_Edirne.jpg/1024px-Evliya_Kasim_Pasha_Mosque_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.545 41.6705)"), "Evliya Kasımpaşa Camii" },
                    { 60, 1, "1561 yılında Kanuni Sultan Süleyman tarafından Mimar Sinan'a yaptırılan, Edirne Sarayı'nın ayakta kalan en önemli parçası olup, imparatorluk adaletinin simgesi olarak Tunca Nehri kıyısında yükselen tarihi kule.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Justice_Tower_Edirne.jpg/1024px-Justice_Tower_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5592 41.6918)"), "Adalet Kasrı Kulesi" },
                    { 61, 1, "15. yüzyılda inşasına başlanan ve yüzyıllar boyunca Osmanlı padişahlarına ev sahipliği yapan, günümüzde kazı ve restorasyon çalışmalarıyla ayağa kaldırılan devasa saray kompleksi.", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Edirne_Palace_Remains.jpg/1024px-Edirne_Palace_Remains.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5585 41.6925)"), "Edirne Sarayı (Saray-ı Cedid-i Amire)" },
                    { 62, 2, "15. yüzyılda Gazi Mihal Bey tarafından Tunca Nehri üzerine inşa ettirilen, Edirne'yi batıya bağlayan stratejik öneme sahip, 16 kemerli görkemli tarihi taş köprü.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Gazi_Mihal_Bridge_Edirne.jpg/1024px-Gazi_Mihal_Bridge_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5407 41.6763)"), "Gazi Mihal Köprüsü" },
                    { 63, 2, "1488 yılında Mimar Hayrettin tarafından Tunca Nehri üzerine inşa edilen, II. Bayezid Külliyesi'ni şehre bağlayan, döneminin mimari zarafetini taşıyan çok kemerli tarihi taş köprü.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/II._Bayezid_Bridge_Edirne.jpg/1024px-II._Bayezid_Bridge_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5475 41.6848)"), "II. Bayezid Köprüsü" },
                    { 64, 4, "Edirne'nin kurtuluşunun 99. yılı anısına oluşturulan, içinde onlarca çeşit gülün bulunduğu ve özellikle bahar aylarında görsel bir şölen sunan şehrin en keyifli tematik parklarından biri.", "https://www.edirne.bel.tr/wp-content/uploads/2021/11/gul-bahcesi-acilis.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5825 41.6645)"), "99. Yıl Edirne Gül Bahçesi" },
                    { 65, 4, "Edirne merkeze bağlı Yolageldi Köyü yakınlarında bulunan, doğa yürüyüşü ve olta balıkçılığı için tercih edilen, huzurlu atmosferiyle bilinen doğal gölet alanı.", "https://lh5.googleusercontent.com/p/AF1QipNqYv9u-1V_v9B-Y6E9X6S4", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8525 41.5642)"), "Yolageldi Köyü - Bağlar Gölü" },
                    { 66, 2, "1912-1913 Balkan Savaşı sırasında Edirne savunmasında şehit düşen askerlerin anısına, Sarayiçi bölgesinde inşa edilen ve her yıl anma törenlerine ev sahipliği yapan manevi değeri yüksek anıt alan.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/Balkan_Wars_Memorial_Edirne.jpg/1024px-Balkan_Wars_Memorial_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5615 41.6922)"), "Balkan Şehitliği" },
                    { 67, 2, "Edirne yaprak ciğerini tanıtmak amacıyla yapılan, 2 ton ağırlığı ve 7 metrelik çapıyla Guinness Rekorlar Kitabı'na giren devasa sembolik tava.", "https://www.edirne.bel.tr/wp-content/uploads/2018/05/dev-tava.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.532 41.6665)"), "Dünyanın En Büyük Tavası" },
                    { 68, 2, "Edirne'nin düşman işgalinden kurtuluşunun 100. yılı anısına inşa edilen, şehrin bağımsızlık mücadelesini ve bir asırlık özgürlüğünü simgeleyen modern anıt kompleksi.", "https://www.edirne.bel.tr/wp-content/uploads/2022/11/100-yil-aniti.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.541 41.6885)"), "Edirne'nin Kurtuluşunun 100. Yıl Anıtı" },
                    { 69, 2, "15. yüzyılda Edirne Sarayı bünyesinde inşa edilen, saray ahalisinin kullanımı için tasarlanmış ve günümüze kadar ulaşan en önemli saray yapılarından biri olan tarihi hamam.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Kum_Kasri_Hamami_Edirne.jpg/1024px-Kum_Kasri_Hamami_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5582 41.6932)"), "Kum Kasrı Hamamı" },
                    { 70, 3, "Türkiye'nin önemli doğa tarihi müzelerinden biri olup; içerisinde fosil örnekleri, mineral çeşitleri ve bölgeye özgü biyolojik türlerin sergilendiği, Karaağaç yerleşkesinde bulunan bilimsel ve eğitim odaklı müze.", "https://dogatarihimuzesi.trakya.edu.tr/resim/dogatarihi1.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5235 41.6528)"), "Trakya Üniversitesi Doğa Tarihi Müzesi" },
                    { 71, 2, "Balkan Savaşları'nda Edirne savunmasının merkezi olan, Şükrü Paşa'nın karargahı olarak kullanılan ve günümüzde modern bir açık hava müzesine dönüştürülen şehrin en büyük savunma tabyası.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Hidirllik_Bastion_Edirne.jpg/1024px-Hidirllik_Bastion_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5412 41.6895)"), "Hıdırlık Tabyaları (Balkan Tarihi Müzesi)" },
                    { 72, 2, "1667-1670 yılları arasında Sadrazam Merzifonlu Kara Mustafa Paşa tarafından yaptırılan, Bedesten Çarşısı köşesinde yer alan ve klasik Osmanlı çeşme mimarisinin en güzel örneklerinden biri olan tarihi yapı.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/Kara_Mustafa_Pasha_Fountain_Edirne.jpg/1024px-Kara_Mustafa_Pasha_Fountain_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5578 41.6765)"), "Merzifonlu Kara Mustafa Paşa Çeşmesi" },
                    { 73, 4, "Osmanlı döneminde sarayın has bahçesi olarak kullanılan, içerisinde yüzyıllık ağaçların ve şifalı bitkilerin bulunduğu, Tunca Nehri ile çevrili Edirne'nin en önemli doğal sit alanı.", "https://www.edirne.bel.tr/wp-content/uploads/2019/04/tavuk-ormani.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.557 41.696)"), "Sarayiçi Tavuk Ormanı" },
                    { 74, 2, "Selimiye Camii'nin gölgesinde yer alan, geç Osmanlı dönemi sivil mimari özelliklerini taşıyan, günümüzde de tarihi dokusu korunarak emniyet birimi olarak kullanılan estetik yapı.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Edirne_Police_Station.jpg/1024px-Edirne_Police_Station.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5612 41.679)"), "Tarihi Selimiye Karakolu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Fatih Sultan Mehmet dönemine tarihlenen ve yan yana bulunan bu iki tarihi yapı, Osmanlı eğitim sisteminin önemli merkezlerindendir; Saatli Medrese günümüzde Fatih Sultan Mehmet Müzesi olarak hizmet vermektedir.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Sultan II. Murad'ın beylerbeyi Sinan Paşa tarafından Tunca Nehri yakınlarında yaptırılan, Edirne'deki tek minareli ve erken dönem Osmanlı mimarisinin özgün detaylarını taşıyan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Beylerbeyi Camii ile aynı dönemde inşa edilen, Osmanlı hamam mimarisinin klasik özelliklerini taşıyan ve günümüzde de kullanılan tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Sultan II. Murad döneminde inşa edilen, Osmanlı döneminde konaklama merkezi olarak kullanılan ve günümüzde restorasyon sonrası kültürel etkinliklere ev sahipliği yapan tarihi yapı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Edirne Valisi Mezit Bey tarafından 15. yüzyılda yaptırılan, zemin seviyesinden aşağıda olduğu için 'Çukur Hamam' olarak da bilinen ve günümüzde hala hizmet veren tarihi Osmanlı hamamı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "Sultan II. Murad tarafından yaptırılan, özellikle iç mekanındaki nadide 15. yüzyıl çinileri ve hat sanatının seçkin örnekleriyle tanınan, şehrin hakim bir tepesinde yer alan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Sultan II. Murad döneminde Saray-ı Cedid-i Amire (Yeni Saray) kompleksinin bir parçası olarak inşa edilen, Selimiye Camii'nin hemen yakınında bulunan ve restorasyon sonrası ziyarete açılan tarihi Osmanlı hamamı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Mimar Sinan tarafından Sokollu Mehmet Paşa adına inşa edilen, çifte hamam planıyla tasarlanmış, Edirne'deki en büyük ve görkemli Osmanlı hamamlarından biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "Kaleiçi semtinde yer alan ve 15. yüzyılda inşa edildiği tahmin edilen, günümüzde büyük ölçüde harabe durumda olmasına rağmen Edirne'nin askeri ve sosyal geçmişine ışık tutan tarihi hamam yapısı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Her yıl 5-6 Mayıs tarihlerinde Sarayiçi'nde kutlanan, baharın gelişini simgeleyen asırlık Roman geleneği ve dev Kakava ateşinin yakıldığı muazzam festival.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "UNESCO Somut Olmayan Kültürel Miras Listesi'nde yer alan, 1361 yılından beri Sarayiçi Er Meydanı'nda düzenlenen dünyanın en eski spor organizasyonlarından biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Yerel tohumların korunması ve gelecek nesillere aktarılması amacıyla Edirne Belediyesi tarafından düzenlenen, bölge çiftçilerini ve doğaseverleri bir araya getiren etkinlik.");
        }
    }
}
