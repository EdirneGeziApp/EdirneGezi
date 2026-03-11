using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seed20EdirnePlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IconUrl", "Name" },
                values: new object[,]
                {
                    { 1, null, "Tarihi Eser" },
                    { 2, null, "Yöresel Lezzet" },
                    { 3, null, "Müze" },
                    { 4, null, "Doğa ve Park" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mimar Sinan'ın ustalık eseri.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5594 41.678)"), "Selimiye Camii" },
                    { 2, 2, "Meşhur Edirne tava ciğeri.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.555 41.675)"), "Tarihi Ciğerci Niyazi Usta" },
                    { 3, 1, "Gün batımının harika izlendiği tarihi köprü.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5492 41.6633)"), "Meriç Köprüsü" },
                    { 4, 3, "Su ve müzik sesiyle şifa dağıtan tarihi mekan.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5414 41.6853)"), "Sağlık Müzesi (II. Bayezid Külliyesi)" },
                    { 5, 4, "Meriç nehri kıyısında devasa doğa parkı.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.535 41.66)"), "Söğütlük Kent Ormanı" },
                    { 6, 1, "Devasa hat yazılarıyla ünlü tarihi cami.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5555 41.6766)"), "Eski Cami" },
                    { 7, 2, "Selimiye'nin karşısındaki efsanevi ciğerci.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5552 41.676)"), "Aydın Tava Ciğer" },
                    { 8, 3, "Şehrin binlerce yıllık tarihini anlatan müze.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5582 41.6789)"), "Edirne Kent Müzesi" },
                    { 9, 1, "Mimar Sinan'ın Edirne'deki muazzam kervansarayı.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5561 41.6758)"), "Rüstem Paşa Kervansarayı" },
                    { 10, 4, "Tarihi güreşlerin yapıldığı yeşil alan.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5588 41.6931)"), "Sarayiçi Kırkpınar Er Meydanı" },
                    { 11, 1, "Osmanlı mimarisinde yeni bir dönemi başlatan eser.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5539 41.6778)"), "Üç Şerefeli Cami" },
                    { 12, 3, "Edirne savunmasının kahramanı Şükrü Paşa'nın anıtı.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5645 41.6822)"), "Şükrü Paşa Anıtı ve Balkan Savaşı Müzesi" },
                    { 13, 1, "Günümüzde Trakya Üniversitesi Güzel Sanatlar Fakültesi olan tarihi gar.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5292 41.65)"), "Karaağaç Tarihi Tren Garı" },
                    { 14, 1, "Karaağaç'ta bulunan ve Lozan Barış Antlaşması'nı simgeleyen anıt.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5285 41.6495)"), "Lozan Anıtı ve Meydanı" },
                    { 15, 2, "Edirne'nin meşhur tarihi badem ezmecisi.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.554 41.676)"), "Keçecizade Badem Ezmecisi" },
                    { 16, 2, "Ciğer sevmeyenler için Edirne'nin en meşhur tarihi köftecisi.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5555 41.6755)"), "Köfteci Osman" },
                    { 17, 1, "Avrupa'nın en büyük sinagoglarından biri, restore edilmiş muhteşem yapı.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5511 41.6738)"), "Edirne Büyük Sinagogu" },
                    { 18, 1, "Kıyık semtinde bulunan, restore edilmiş tarihi Bulgar Ortodoks kilisesi.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.568 41.686)"), "Sweti George Bulgar Kilisesi" },
                    { 19, 3, "Balkanların en büyük çocuk ve interaktif eğitim müzesi.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.585 41.662)"), "Hasan Ali Yücel Çocuk Müzesi" },
                    { 20, 1, "Tunca nehri üzerindeki zarif Osmanlı köprüsü.", null, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5525 41.6685)"), "Tunca Köprüsü" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
