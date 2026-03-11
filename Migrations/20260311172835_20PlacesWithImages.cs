using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20PlacesWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Selimiye_Mosque_in_Edirne.jpg/1024px-Selimiye_Mosque_in_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.deliveryhero.io/image/otlob/Products/296726/Main.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Edirne_Meric_Bridge.jpg/1024px-Edirne_Meric_Bridge.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Complex_of_Sultan_Bayezid_II_Health_Museum.jpg/1024px-Complex_of_Sultan_Bayezid_II_Health_Museum.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://edirne.bel.tr/wp-content/uploads/2023/06/sogutluk.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Edirne_Old_Mosque_Interior.jpg/1024px-Edirne_Old_Mosque_Interior.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.aydinciğer.com/img/slider1.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://edirnekentmuzesi.org.tr/wp-content/uploads/2021/05/muze-bina.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Rustem_Pasha_Caravanserai_Edirne.jpg/1024px-Rustem_Pasha_Caravanserai_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://edirne.bel.tr/wp-content/uploads/2023/07/kirkpinar.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Uc_Serefeli_Mosque.jpg/1024px-Uc_Serefeli_Mosque.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.edirne.gov.tr/kurumlar/edirne.gov.tr/Haberler/2021/MART/26/sukru-pasa.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Karaagac_Railway_Station_Edirne.jpg/1024px-Karaagac_Railway_Station_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Lausanne_Treaty_Monument_Edirne.jpg/1024px-Lausanne_Treaty_Monument_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.kececizade.com/images/kategori-resimler/badem-ezmesi.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://kofteciosman.com/wp-content/uploads/2019/04/kofte.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Great_Synagogue_of_Edirne.jpg/1024px-Great_Synagogue_of_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Sveti_Georgi_Church_Edirne.jpg/1024px-Sveti_Georgi_Church_Edirne.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.edirne.bel.tr/wp-content/uploads/2023/05/cocuk-muzesi.jpg");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Tunca_Bridge_Edirne.jpg/1024px-Tunca_Bridge_Edirne.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: null);
        }
    }
}
