using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class destinationAndAddressTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Destinations");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Addresses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Addresses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Clothing", new DateTime(2023, 8, 25, 3, 20, 27, 586, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Games", new DateTime(2023, 9, 26, 17, 19, 26, 677, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 13, 10, 20, 361, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Shoes", new DateTime(2022, 11, 19, 10, 17, 10, 861, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Electronics", new DateTime(2023, 8, 17, 2, 55, 32, 264, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(2836), "Magni ut impedit dolor itaque. Occaecati excepturi at enim expedita veritatis voluptatibus fugiat et voluptates. Qui velit quae veritatis. Ut cum quos qui fugiat sed. Libero nulla voluptas facilis cupiditate voluptas nostrum qui accusamus. Sapiente ut amet ut et aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/264.jpg", "Natashaborough", new TimeSpan(0, 10, 0, 0, 0), 10.72m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4381), "Quod voluptatem quia dolorem. Voluptatem voluptas possimus quod quibusdam quia quos nam sit. Aut voluptatem distinctio sunt ut alias suscipit incidunt. Id provident consequuntur perferendis pariatur mollitia adipisci iste numquam sit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/317.jpg", "Mariannefort", new TimeSpan(0, 9, 0, 0, 0), 90.87m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4615), "Voluptates error aut est. Dolores vitae in hic. Repellat quas quo cupiditate nostrum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1086.jpg", "South Casey", new TimeSpan(0, 9, 0, 0, 0), 43.87m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4722), "Quo id aut voluptas delectus tempore eaque officia. Eum aliquid consequatur. Ut rerum quia. Sapiente maiores ut sed non reiciendis. Aspernatur aut magni. Qui quis fuga.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/866.jpg", "Thielbury", new TimeSpan(0, 8, 0, 0, 0), 23.85m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4835), "Consequuntur sapiente magnam officiis velit ex perspiciatis consectetur. Voluptate ut nemo aut eius nihil laborum dignissimos veniam. Quasi reiciendis quos. Doloribus voluptatem est. Nobis sapiente labore et exercitationem est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Lilaville", new TimeSpan(0, 8, 0, 0, 0), 62.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4955), "Explicabo libero aut architecto laboriosam quo. Optio laboriosam et cupiditate iure corrupti in qui. Dolores fugiat impedit qui.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/437.jpg", "North Misty", 85.36m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5066), "Velit deleniti voluptatem esse aperiam facere cumque natus et. A excepturi voluptatem aut reiciendis rerum omnis earum et. Cum enim aut sit aperiam dolores ut accusamus sapiente totam. Quo eaque odit sed repudiandae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/422.jpg", "North Annamarie", new TimeSpan(0, 8, 0, 0, 0), 76.60m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5199), "Quidem molestiae expedita aliquam ratione omnis soluta tenetur sint deserunt. Ab sit mollitia doloremque dolorum dolorem similique. Deleniti laudantium iste excepturi necessitatibus repellendus ex quam fuga. Unde voluptas eos. Natus quia provident. Illo eos ut eaque unde consequuntur ad maiores est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/854.jpg", "Wilfredmouth", new TimeSpan(0, 8, 0, 0, 0), 51.64m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5352), "Consectetur rerum alias dolor facilis iure quibusdam. Quibusdam soluta repellendus incidunt. Et nisi veniam tenetur tempora dignissimos ut perspiciatis architecto. Laudantium voluptas harum ut. Nam soluta illo tempore quia corrupti.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/422.jpg", "Port Citlalli", new TimeSpan(0, 9, 0, 0, 0), 81.24m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5491), "Aspernatur est voluptas eos. Omnis maiores enim ut dolores voluptas officiis et ullam. Ut facere distinctio quia. Ullam consequuntur aut fugit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/149.jpg", "Priceshire", 30.42m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Addresses");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Destinations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Destinations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(6408), "Et velit omnis. Asperiores corporis quia est quasi molestiae voluptas molestiae laboriosam. Qui magnam commodi minus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1207.jpg", 5.1228999999999996, "133 Dicki Circles, North Elzamouth, French Guiana", 69.493700000000004, "Coletown", new TimeSpan(0, 8, 0, 0, 0), 6.23m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(6752), "Accusamus nesciunt velit. Cum placeat ipsa ut fuga rem labore quo molestiae quasi. Minus aspernatur rem. Non ratione qui et modi est. Cumque rem totam fugit sit deleniti. Eveniet sunt iste amet et ex maiores.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/42.jpg", 86.739900000000006, "44468 Dedrick Well, South Annietown, Bouvet Island (Bouvetoya)", -71.329999999999998, "Pascalehaven", new TimeSpan(0, 8, 0, 0, 0), 21.61m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7005), "Tempore hic ea cumque dolorem tempore. Aut quaerat est et laboriosam. Possimus aut quia ipsam nisi fugiat rem dolor. Consequuntur aliquid qui et excepturi voluptatem et rerum sunt vel. Libero sit voluptas consequatur veniam. Eos est sit porro id harum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/974.jpg", -26.418099999999999, "83038 Champlin Courts, Shermanton, Syrian Arab Republic", -12.806100000000001, "Gregoryborough", new TimeSpan(0, 10, 0, 0, 0), 40.11m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7237), "Nam temporibus sunt laborum quis maxime accusantium. Incidunt iusto ipsum et ipsam aut culpa laudantium pariatur. Aperiam eligendi amet ex. Delectus eum dolore ut itaque consequuntur et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", 7.6527000000000003, "27963 Keeling Mountain, Jaspermouth, Algeria", 59.141100000000002, "East Melody", new TimeSpan(0, 9, 0, 0, 0), 51.47m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7536), "At ipsam est laborum commodi asperiores nesciunt sit. Non error corporis aut. Doloremque porro et facere quidem voluptatem expedita cum suscipit. Sit aut atque voluptate placeat. Est repudiandae sed qui ut voluptatem in atque eveniet dolores. Excepturi accusamus consectetur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", -80.749099999999999, "4791 Nikki Shoals, Jakeport, Algeria", 53.700400000000002, "Lake Dewayneberg", 68.19m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(7828), "Voluptatum sit aut quaerat. Deleniti voluptatem qui repudiandae vel quasi sunt nihil. Repellendus nihil nisi quas dolor et et qui maxime. Esse ad sed blanditiis sit. Impedit corrupti saepe quam facilis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/469.jpg", 3.4855999999999998, "502 Eli Heights, Shayneview, United States of America", 115.086, "Lake Bransonstad", new TimeSpan(0, 9, 0, 0, 0), 37.16m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8047), "Modi nemo quo non est. Temporibus nulla dolore mollitia autem cum et deleniti est. Rerum temporibus amet nobis possimus laborum. Et numquam eum velit et sapiente minus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1153.jpg", 18.040199999999999, "289 Schulist Fork, Lake Dessiefort, Dominica", -104.0581, "North Pascale", new TimeSpan(0, 10, 0, 0, 0), 51.44m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8237), "Officiis occaecati quia id. Officia odit et asperiores et consequatur corporis. Alias rerum eos velit hic molestias blanditiis. Ipsa consequuntur incidunt et nulla. Est asperiores et vero enim fugiat nesciunt quas ad. Tempora iste a ut et sunt ex quae praesentium.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/467.jpg", -83.494500000000002, "964 Willms Keys, Lake Jimmy, Belgium", -119.3754, "Filomenamouth", new TimeSpan(0, 10, 0, 0, 0), 84.48m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 22, 11, 46, 38, 318, DateTimeKind.Local).AddTicks(8512), "Corporis aut qui dolor beatae. Molestiae dolorum cumque quidem quia et officiis voluptas ipsam voluptas. Dolore quibusdam autem quia in unde voluptates molestias. Debitis eligendi et laudantium ut fugit ea atque quas illo. Optio iusto consequatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/791.jpg", 16.572399999999998, "263 Roberta Valley, Adalbertoton, Palestinian Territory", 78.585800000000006, "New Scottyfurt", 49.78m });
        }
    }
}
