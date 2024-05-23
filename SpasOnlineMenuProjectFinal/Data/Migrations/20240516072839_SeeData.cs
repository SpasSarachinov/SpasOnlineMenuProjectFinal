using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpasOnlineMenuProjectFinal.Data.Migrations
{
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ingredients",
                table: "Dishes",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "ImageUrl", "Ingredients", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "https://assets-eu-01.kc-usercontent.com/00b9925d-7322-014e-f702-6ef9aa1a28b4/f509cc3f-85ee-4f27-bd60-1384807311b5/01072018-293.jpg?w=1200&fm=webp&lossless=0&q=80", "яйца,питка, тънки резени бекон, магданоз,лимонов сок", 18m, "Яйца Бенедеикт" },
                    { 2, "https://media-cldnry.s-nbcnews.com/image/upload/t_social_share_1200x630_center,f_auto,q_auto:best/newscms/2020_04/1530595/fluffy-scrambled-eggs-today-main-200121-2.jpg", "яйца, черен пипер, сметана", 8m, "Бъркани яйца" },
                    { 3, "https://dostavka.happy.bg/remote/files/images/215620/fit_640_400.png?rev=1697484896", "Телешки стек с чимичури сос, чушки пимиентос де падрон и пюре от сладък картоф", 25m, "Телешки стек" },
                    { 4, "https://dostavka.happy.bg/remote/files/images/27142/fit_640_400.png?rev=1643806171", "Свински ребра с азиатски барбекю сос, кашу и зелен лук.", 0m, "Ребра Иберико По Азиатски" },
                    { 5, "https://dostavka.happy.bg/remote/files/images/228302/fit_640_400.png?rev=1697363605", "Свински котлет в специална марината, печени картофи, чимичури и пимиентос де падрон.", 30m, "Аржентински котлет" },
                    { 6, "https://dostavka.happy.bg/remote/files/images/6981/fit_640_400.png?rev=1637069133", "Хосомаки краставица 16 бр., Филаделфия сьомга, авокадо и хрупкава темпура 8 бр., Норвежка гора 8 бр.,  Филаделфия пушена сьомга 8 бр., Филаделфия хрупкаво пиле 8 бр.", 25m, "Екстра Суши Комбо 48 БР" },
                    { 7, "https://dostavka.happy.bg/remote/files/images/120941/fit_640_400.png?rev=1675441077", "Чикън Везувий 8 бр., Чикън Кинг 6 бр., Клуб Чикън 4 бр., Дракон пиле 4 бр., Трюфел пиле 8 бр.", 30m, "Макси Чикън 30 БР" },
                    { 8, "https://dostavka.happy.bg/remote/files/images/116440/fit_640_400.png?rev=1674131382", "Футомаки хрупкаво пиле с Филаделфия и амарант 6 бр., Филаделфия сьомга, авокадо и хрупкава темпура 4 бр., Емирейтс рол с манго и Филаделфия 4 бр., Хепи майонеза, унаги сос и ядлива златна пудра.", 35m, "Бурж Ал Араб 14 БР" },
                    { 9, "https://dostavka.happy.bg/remote/files/images/3882/fit_640_400.png?rev=1626000157", "Суфле с течен център от шоколад.", 5m, "Суфле С Течен Център Шоколад" },
                    { 10, "https://dostavka.happy.bg/remote/files/images/353328/fit_640_400.png?rev=1707735140", "Хрупкав бисквитен блат, маскарпоне крем, сладко от ягоди и шоколад.", 5m, "Нутела С Ягоди И Маскарпоне" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredients",
                table: "Dishes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000);
        }
    }
}
