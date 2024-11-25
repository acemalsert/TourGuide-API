using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class countryTableMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Country_CountryId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Automotive", new DateTime(2022, 11, 10, 4, 5, 22, 847, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Tools", new DateTime(2023, 3, 7, 19, 35, 41, 622, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 10, 3, 17, 239, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Clothing", new DateTime(2023, 12, 11, 17, 30, 44, 29, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Computers", new DateTime(2024, 8, 1, 9, 41, 33, 334, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(4457), "Iure expedita minus harum nostrum alias. Aperiam perspiciatis omnis autem eos voluptatem consectetur. Dolor excepturi est facilis. Facere dolore et eos nulla hic. Omnis dolorem qui voluptas dolore nemo assumenda et eum ut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/783.jpg", 7.6904000000000003, "749 Everardo Centers, Andreaneshire, Venezuela", -67.244600000000005, "Langoshstad", new TimeSpan(0, 9, 0, 0, 0), 75.03m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(6408), "Et velit omnis. Asperiores corporis quia est quasi molestiae voluptas molestiae laboriosam. Qui magnam commodi minus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1207.jpg", 5.1228999999999996, "133 Dicki Circles, North Elzamouth, French Guiana", 69.493700000000004, "Coletown", 6.23m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(6752), "Accusamus nesciunt velit. Cum placeat ipsa ut fuga rem labore quo molestiae quasi. Minus aspernatur rem. Non ratione qui et modi est. Cumque rem totam fugit sit deleniti. Eveniet sunt iste amet et ex maiores.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/42.jpg", 86.739900000000006, "44468 Dedrick Well, South Annietown, Bouvet Island (Bouvetoya)", -71.329999999999998, "Pascalehaven", new TimeSpan(0, 8, 0, 0, 0), 21.61m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7005), "Tempore hic ea cumque dolorem tempore. Aut quaerat est et laboriosam. Possimus aut quia ipsam nisi fugiat rem dolor. Consequuntur aliquid qui et excepturi voluptatem et rerum sunt vel. Libero sit voluptas consequatur veniam. Eos est sit porro id harum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/974.jpg", -26.418099999999999, "83038 Champlin Courts, Shermanton, Syrian Arab Republic", -12.806100000000001, "Gregoryborough", 40.11m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7237), "Nam temporibus sunt laborum quis maxime accusantium. Incidunt iusto ipsum et ipsam aut culpa laudantium pariatur. Aperiam eligendi amet ex. Delectus eum dolore ut itaque consequuntur et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", 7.6527000000000003, "27963 Keeling Mountain, Jaspermouth, Algeria", 59.141100000000002, "East Melody", 51.47m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7536), "At ipsam est laborum commodi asperiores nesciunt sit. Non error corporis aut. Doloremque porro et facere quidem voluptatem expedita cum suscipit. Sit aut atque voluptate placeat. Est repudiandae sed qui ut voluptatem in atque eveniet dolores. Excepturi accusamus consectetur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", -80.749099999999999, "4791 Nikki Shoals, Jakeport, Algeria", 53.700400000000002, "Lake Dewayneberg", new TimeSpan(0, 8, 0, 0, 0), 68.19m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7828), "Voluptatum sit aut quaerat. Deleniti voluptatem qui repudiandae vel quasi sunt nihil. Repellendus nihil nisi quas dolor et et qui maxime. Esse ad sed blanditiis sit. Impedit corrupti saepe quam facilis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/469.jpg", 3.4855999999999998, "502 Eli Heights, Shayneview, United States of America", 115.086, "Lake Bransonstad", new TimeSpan(0, 9, 0, 0, 0), 37.16m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8047), "Modi nemo quo non est. Temporibus nulla dolore mollitia autem cum et deleniti est. Rerum temporibus amet nobis possimus laborum. Et numquam eum velit et sapiente minus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1153.jpg", 18.040199999999999, "289 Schulist Fork, Lake Dessiefort, Dominica", -104.0581, "North Pascale", 51.44m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8237), "Officiis occaecati quia id. Officia odit et asperiores et consequatur corporis. Alias rerum eos velit hic molestias blanditiis. Ipsa consequuntur incidunt et nulla. Est asperiores et vero enim fugiat nesciunt quas ad. Tempora iste a ut et sunt ex quae praesentium.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/467.jpg", -83.494500000000002, "964 Willms Keys, Lake Jimmy, Belgium", -119.3754, "Filomenamouth", new TimeSpan(0, 10, 0, 0, 0), 84.48m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8512), "Corporis aut qui dolor beatae. Molestiae dolorum cumque quidem quia et officiis voluptas ipsam voluptas. Dolore quibusdam autem quia in unde voluptates molestias. Debitis eligendi et laudantium ut fugit ea atque quas illo. Optio iusto consequatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/791.jpg", 16.572399999999998, "263 Roberta Valley, Adalbertoton, Palestinian Territory", 78.585800000000006, "New Scottyfurt", new TimeSpan(0, 9, 0, 0, 0), 49.78m });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Clothing", new DateTime(2024, 1, 17, 10, 12, 22, 765, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Shoes", new DateTime(2022, 10, 24, 17, 9, 43, 997, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 7, 32, 51, 914, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Sports", new DateTime(2024, 5, 26, 19, 41, 43, 120, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Books", new DateTime(2023, 11, 9, 13, 35, 57, 56, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(546), "Consequatur hic commodi sapiente sed excepturi error. Et esse dolorem quisquam id dicta sequi. Ipsa ut aperiam id vel tenetur libero corporis. Consequatur eum consequatur ullam eaque ut quo quisquam dolor corporis. Omnis voluptates optio aliquid ipsum enim voluptatem dolorem beatae consequatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/369.jpg", -65.055199999999999, "86447 Streich Mountain, Lake Neldahaven, Egypt", 90.253200000000007, "East Havenland", new TimeSpan(0, 8, 0, 0, 0), 22.69m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(3415), "Sunt dolorem perferendis molestiae illo quia. Repellat dolore laudantium debitis. Debitis dolore quia. Molestias hic ut beatae animi. Natus cupiditate omnis voluptas reiciendis unde.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/256.jpg", -16.765799999999999, "419 Donnelly Shoal, North Joeyhaven, Iceland", -33.119700000000002, "Romaguerachester", 27.05m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(3918), "Aut voluptas voluptate quis vel. Fugit consequatur rem alias. Ipsam sit aliquid et ducimus omnis. Perspiciatis earum nam reiciendis. Dignissimos aut praesentium rerum aliquid et. Consequatur rerum amet et deserunt et sunt mollitia non.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/272.jpg", 73.547799999999995, "722 Pfannerstill Glens, Port Katrina, Uruguay", -5.8022, "Brannonborough", new TimeSpan(0, 9, 0, 0, 0), 85.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4264), "Est excepturi totam animi. Sunt id est voluptatem. Harum maxime expedita minus voluptatum animi. Possimus molestias voluptatem exercitationem. Ad quia voluptas. Molestiae vero adipisci.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/271.jpg", 53.741799999999998, "44049 Smith Burg, West Hailey, Ethiopia", -144.8646, "Wunschfort", 32.92m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4543), "Rerum ipsam non dolores id. Omnis excepturi tempore dicta. Minus est ex eligendi sit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/153.jpg", -77.568700000000007, "0028 Kaden Hill, North Kendra, Latvia", 36.471499999999999, "Port Fanny", 53.47m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4774), "Cumque dolore voluptatibus explicabo maiores consequuntur molestiae repellendus. Sapiente ea vero voluptas in nemo. Architecto quibusdam ab.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/666.jpg", -25.367999999999999, "952 Rita Corner, Athenaville, Guyana", -175.88300000000001, "Klockoland", new TimeSpan(0, 9, 0, 0, 0), 49.80m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5000), "Minus sit similique quia et praesentium reiciendis voluptatum rerum sit. Minus saepe aut consequatur molestiae mollitia in quaerat nihil velit. Quo totam at asperiores inventore. In perspiciatis asperiores amet quia qui mollitia est accusantium natus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/436.jpg", 78.963300000000004, "48494 Legros Hollow, East Vanceton, Brunei Darussalam", -173.56049999999999, "O'Connerside", new TimeSpan(0, 8, 0, 0, 0), 23.67m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5367), "Omnis incidunt nihil earum. Sapiente ut sed nihil molestiae. Suscipit veniam exercitationem tenetur omnis quasi cumque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1180.jpg", 89.818200000000004, "2175 Juliana Valley, Zoramouth, Maldives", -83.902199999999993, "Port Devin", 47.19m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5598), "Voluptatem modi eveniet itaque molestiae. Occaecati ab odit ex tenetur deserunt quo et ut qui. Tenetur consequatur nihil ut excepturi quas velit culpa in modi. Ullam neque ex natus porro beatae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1009.jpg", -61.986400000000003, "28231 Audra Burgs, Veumshire, Nigeria", -32.0503, "South Breanna", new TimeSpan(0, 9, 0, 0, 0), 97.25m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(6162), "Qui modi odit minima sunt minima tempora. Praesentium ab ut nihil maxime dolores earum aut tempore rem. Voluptas dolor est et tenetur voluptatem ab dignissimos. Voluptates quas vel tempora quia blanditiis pariatur laborum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", -48.005499999999998, "894 Gerhard Corner, Nathenmouth, Bosnia and Herzegovina", -141.5506, "Kuvalisbury", new TimeSpan(0, 8, 0, 0, 0), 94.74m });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Country_CountryId",
                table: "Addresses",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
