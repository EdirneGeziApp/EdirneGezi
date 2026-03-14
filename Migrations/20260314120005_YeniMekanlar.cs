using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class YeniMekanlar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 45, 3, "Sultan II. Murad döneminde inşa edilen, Osmanlı döneminde konaklama merkezi olarak kullanılan ve günümüzde restorasyon sonrası kültürel etkinliklere ev sahipliği yapan tarihi yapı.", "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/NISAN/01/devecihan/IMG_2044.JPG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5535 41.6772)"), "Deveci Han" },
                    { 46, 4, "Edirne Valisi Mezit Bey tarafından 15. yüzyılda yaptırılan, zemin seviyesinden aşağıda olduğu için 'Çukur Hamam' olarak da bilinen ve günümüzde hala hizmet veren tarihi Osmanlı hamamı.", "https://www.edirnekulturturizm.gov.tr/resim/304246,mezit-bey-hamami-edirnejpg.png?0", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5568 41.6767)"), "Mezit Bey Hamamı" },
                    { 47, 1, "Sultan II. Murad tarafından yaptırılan, özellikle iç mekanındaki nadide 15. yüzyıl çinileri ve hat sanatının seçkin örnekleriyle tanınan, şehrin hakim bir tepesinde yer alan tarihi cami.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Muradiye_Mosque_Edirne_11.jpg/1024px-Muradiye_Mosque_Edirne_11.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5648 41.6825)"), "Muradiye Camii" },
                    { 48, 4, "Sultan II. Murad döneminde Saray-ı Cedid-i Amire (Yeni Saray) kompleksinin bir parçası olarak inşa edilen, Selimiye Camii'nin hemen yakınında bulunan ve restorasyon sonrası ziyarete açılan tarihi Osmanlı hamamı.", "https://www.edirnekulturturizm.gov.tr/resim/304247,saray-hamami-edirnejpg.png?0", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5605 41.6788)"), "Saray Hamamı" },
                    { 49, 4, "Mimar Sinan tarafından Sokollu Mehmet Paşa adına inşa edilen, çifte hamam planıyla tasarlanmış, Edirne'deki en büyük ve görkemli Osmanlı hamamlarından biri.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Sokollu_Mehmet_Pasha_Hamam_Edirne.jpg/1024px-Sokollu_Mehmet_Pasha_Hamam_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5585 41.6775)"), "Sokollu Mehmet Paşa Hamamı" },
                    { 50, 4, "Kaleiçi semtinde yer alan ve 15. yüzyılda inşa edildiği tahmin edilen, günümüzde büyük ölçüde harabe durumda olmasına rağmen Edirne'nin askeri ve sosyal geçmişine ışık tutan tarihi hamam yapısı.", "https://www.edirnekulturturizm.gov.tr/resim/304248,yenicerihamami-edirnejpg.png?0", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5485 41.6722)"), "Yeniçeri Hamamı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
