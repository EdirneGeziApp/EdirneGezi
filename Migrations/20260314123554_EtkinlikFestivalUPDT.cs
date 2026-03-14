using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class EtkinlikFestivalUPDT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 51, 7, "Her yıl 5-6 Mayıs tarihlerinde Sarayiçi'nde kutlanan, baharın gelişini simgeleyen asırlık Roman geleneği ve dev Kakava ateşinin yakıldığı muazzam festival.", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Kakava_Festivities_Edirne.jpg/1024px-Kakava_Festivities_Edirne.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.559 41.6935)"), "Kakava & Hıdırellez Şenlikleri" },
                    { 52, 7, "UNESCO Somut Olmayan Kültürel Miras Listesi'nde yer alan, 1361 yılından beri Sarayiçi Er Meydanı'nda düzenlenen dünyanın en eski spor organizasyonlarından biri.", "https://edirne.bel.tr/wp-content/uploads/2023/07/kirkpinar.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5588 41.6931)"), "Tarihî Kırkpınar Yağlı Güreşleri Festivali" },
                    { 53, 7, "Yerel tohumların korunması ve gelecek nesillere aktarılması amacıyla Edirne Belediyesi tarafından düzenlenen, bölge çiftçilerini ve doğaseverleri bir araya getiren etkinlik.", "https://www.edirne.bel.tr/wp-content/uploads/2022/03/tohum-takas.jpg", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5545 41.676)"), "Tohum Takas Şenliği" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 53);
        }
    }
}
