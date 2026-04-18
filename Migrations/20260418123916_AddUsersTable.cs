using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "II. Murad tarafından Tunca Nehri kıyısında yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Bizans sınırında görev yapan akıncı beyi Gazi Mihal tarafından yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Defterdar Mahmut Paşa tarafından Mimar Sinan'a yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Fatih Sultan Mehmet'in eşi Sittişah Hatun tarafından yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Edirne'nin Kaleiçi semtinde bulunan tarihi kilise.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Mimar Sinan tarafından inşa edilen tarihi kapalı çarşı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Selimiye Camii'ne gelir sağlamak amacıyla inşa edilen tarihi çarşı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Edirne'nin en eski kapalı çarşısı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Osmanlı eğitim sisteminin önemli merkezlerindendir.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Mimar Sinan tarafından inşa edilen görkemli hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Karaağaç mevkisinde, 15. yüzyıl Erken Osmanlı dönemine ait tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Sarayiçi bölgesinde bulunan tarihi türbe.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Fatih Sultan Mehmet'in kuşçubaşısı tarafından yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Edirne'nin tarihi mahallelerinden birine adını veren tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "Çelebi Sultan Mehmed'in kızı tarafından yaptırılan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "15. yüzyılda Tunca Nehri kıyısında yaptırılan tarihi yapı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "Kanuni Sultan Süleyman tarafından Mimar Sinan'a yaptırılan tarihi kule.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "15. yüzyılda inşasına başlanan devasa saray kompleksi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "15. yüzyılda 16 kemerli görkemli tarihi taş köprü.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "1488 yılında inşa edilen çok kemerli tarihi taş köprü.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "Onlarca çeşit gülün bulunduğu tematik park.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "Doğa yürüyüşü ve olta balıkçılığı için tercih edilen doğal gölet alanı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "1912-1913 Balkan Savaşı şehitleri anısına inşa edilen anıt alan.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "7 metrelik çapıyla Guinness Rekorlar Kitabı'na giren devasa sembolik tava.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Edirne'nin kurtuluşunun 100. yılı anısına inşa edilen modern anıt kompleksi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "15. yüzyılda Edirne Sarayı bünyesinde inşa edilen tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "Fosil örnekleri ve bölgeye özgü biyolojik türlerin sergilendiği bilimsel müze.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "Balkan Savaşları'nda Edirne savunmasının merkezi olan tarihi tabya.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "Klasik Osmanlı çeşme mimarisinin en güzel örneklerinden biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Tunca Nehri ile çevrili Edirne'nin en önemli doğal sit alanı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Geç Osmanlı dönemi sivil mimari özelliklerini taşıyan tarihi yapı.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "II. Murad tarafından Tunca Nehri kıyısında yaptırılan, haziresinde Osmanlı şehzadelerinin kabirlerini barındıran tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Bizans sınırında görev yapan akıncı beyi Gazi Mihal tarafından Tunca Nehri kıyısında yaptırılan, erken dönem Osmanlı mimarisinin önemli örneklerinden biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Defterdar Mahmut Paşa tarafından Mimar Sinan'a yaptırılan, özgün mimarisi ve merkezi konumuyla dikkat çeken Osmanlı dönemi camii.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Fatih Sultan Mehmet'in eşi Sittişah Hatun tarafından yaptırılan, Edirne'deki erken Osmanlı mimarisinin ve tek kubbeli yapı tipinin en zarif örneklerinden biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Edirne'nin Kaleiçi semtinde bulunan, 19. yüzyılda İtalyan topluluğu tarafından inşa edilen ve şehrin çok kültürlü mirasını yansıtan tarihi kilise.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Mimar Sinan tarafından Hersekli Semiz Ali Paşa adına inşa edilen, içinde çok sayıda dükkan barındıran ve günümüzde de Edirne ticaretinin kalbi olan tarihi kapalı çarşı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Selimiye Camii'ne gelir sağlamak amacıyla Mimar Sinan tarafından inşa edilen, caminin hemen altında yer alan tarihi ve otantik kapalı çarşı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Eski Camii'ye vakıf olarak Çelebi Mehmet tarafından yaptırılan, Edirne'nin en eski kapalı çarşısı olan ve kilitli kemerleriyle ünlü tarihi ticaret merkezi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Fatih Sultan Mehmet dönemine tarihlenen ve yan yana bulunan bu iki tarihi yapı, Osmanlı eğitim sisteminin önemli merkezlerindendir.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Mimar Sinan tarafından Sokollu Mehmet Paşa adına inşa edilen görkemli hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Karaağaç mevkisinde, 15. yüzyıl Erken Osmanlı dönemine ait almaşık duvar yapısıyla dikkat çeken tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Sarayiçi bölgesinde bulunan, Edirne'nin fethi sırasında şehit düştüğüne inanılan Hıdır Baba'ya ait, özellikle Kakava döneminde ziyaret edilen tarihi türbe.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Fatih Sultan Mehmet'in kuşçubaşısı Doğan Bey tarafından yaptırılan, özgün minaresi ve erken Osmanlı dönemi mimarisiyle bilinen tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Edirne'nin tarihi mahallelerinden birine adını veren, klasik Osmanlı mimarisini yansıtan ve mahalle kültürünün merkezinde yer alan tarihi cami.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "Çelebi Sultan Mehmed'in kızı Selçuk Hatun tarafından 15. yüzyılda yaptırılan, Edirne'nin tarihi dokusunu yansıtan zarif ve butik bir Osmanlı camisi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "15. yüzyılda Kasımpaşa tarafından Tunca Nehri kıyısında yaptırılan, nehir taşkınlarına karşı koruma amacıyla inşa edilen rıhtımı ve haziresindeki Evliya Kasımpaşa'nın türbesiyle bilinen tarihi yapı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "1561 yılında Kanuni Sultan Süleyman tarafından Mimar Sinan'a yaptırılan, Edirne Sarayı'nın ayakta kalan en önemli parçası olup, imparatorluk adaletinin simgesi olarak Tunca Nehri kıyısında yükselen tarihi kule.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "15. yüzyılda inşasına başlanan ve yüzyıllar boyunca Osmanlı padişahlarına ev sahipliği yapan, günümüzde kazı ve restorasyon çalışmalarıyla ayağa kaldırılan devasa saray kompleksi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "15. yüzyılda Gazi Mihal Bey tarafından Tunca Nehri üzerine inşa ettirilen, Edirne'yi batıya bağlayan stratejik öneme sahip, 16 kemerli görkemli tarihi taş köprü.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "1488 yılında Mimar Hayrettin tarafından Tunca Nehri üzerine inşa edilen, II. Bayezid Külliyesi'ni şehre bağlayan, döneminin mimari zarafetini taşıyan çok kemerli tarihi taş köprü.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "Edirne'nin kurtuluşunun 99. yılı anısına oluşturulan, içinde onlarca çeşit gülün bulunduğu ve özellikle bahar aylarında görsel bir şölen sunan şehrin en keyifli tematik parklarından biri.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "Edirne merkeze bağlı Yolageldi Köyü yakınlarında bulunan, doğa yürüyüşü ve olta balıkçılığı için tercih edilen, huzurlu atmosferiyle bilinen doğal gölet alanı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "1912-1913 Balkan Savaşı sırasında Edirne savunmasında şehit düşen askerlerin anısına, Sarayiçi bölgesinde inşa edilen ve her yıl anma törenlerine ev sahipliği yapan manevi değeri yüksek anıt alan.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Edirne yaprak ciğerini tanıtmak amacıyla yapılan, 2 ton ağırlığı ve 7 metrelik çapıyla Guinness Rekorlar Kitabı'na giren devasa sembolik tava.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Edirne'nin düşman işgalinden kurtuluşunun 100. yılı anısına inşa edilen, şehrin bağımsızlık mücadelesini ve bir asırlık özgürlüğünü simgeleyen modern anıt kompleksi.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "15. yüzyılda Edirne Sarayı bünyesinde inşa edilen, saray ahalisinin kullanımı için tasarlanmış ve günümüze kadar ulaşan en önemli saray yapılarından biri olan tarihi hamam.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "Türkiye'nin önemli doğa tarihi müzelerinden biri olup; içerisinde fosil örnekleri, mineral çeşitleri ve bölgeye özgü biyolojik türlerin sergilendiği, Karaağaç yerleşkesinde bulunan bilimsel ve eğitim odaklı müze.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "Balkan Savaşları'nda Edirne savunmasının merkezi olan, Şükrü Paşa'nın karargahı olarak kullanılan ve günümüzde modern bir açık hava müzesine dönüştürülen şehrin en büyük savunma tabyası.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "1667-1670 yılları arasında Sadrazam Merzifonlu Kara Mustafa Paşa tarafından yaptırılan, Bedesten Çarşısı köşesinde yer alan ve klasik Osmanlı çeşme mimarisinin en güzel örneklerinden biri olan tarihi yapı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Osmanlı döneminde sarayın has bahçesi olarak kullanılan, içerisinde yüzyıllık ağaçların ve şifalı bitkilerin bulunduğu, Tunca Nehri ile çevrili Edirne'nin en önemli doğal sit alanı.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Selimiye Camii'nin gölgesinde yer alan, geç Osmanlı dönemi sivil mimari özelliklerini taşıyan, günümüzde de tarihi dokusu korunarak emniyet birimi olarak kullanılan estetik yapı.");
        }
    }
}
