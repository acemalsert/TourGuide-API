using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UserTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 17, 1, 18, 32, 355, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 30, 10, 39, 51, 656, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Games", new DateTime(2023, 12, 26, 21, 59, 18, 879, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Movies", new DateTime(2022, 11, 16, 8, 18, 16, 55, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Jewelery", new DateTime(2022, 11, 3, 2, 33, 9, 172, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(5939), "Ratione doloremque nostrum optio illum. Repellat et odio harum et consequatur vel et quisquam. Consequuntur et dolorem voluptas numquam et tempora corporis. Repudiandae nesciunt iusto. Asperiores sed molestiae quidem recusandae eum. Nulla non dolorem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/77.jpg", 22.244199999999999, "591 Blanda Centers, East Loraland, Northern Mariana Islands", -71.397499999999994, "North Kraigmouth", 38.88m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(7924), "Odio officia id. Rerum ipsa ea recusandae odio beatae cumque iusto illo. Voluptate itaque eveniet excepturi saepe ratione dolor quia. Et architecto omnis voluptates aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1153.jpg", 11.8492, "361 Danika Mountains, South Jacky, Bangladesh", -91.710499999999996, "North Herbert", new TimeSpan(0, 8, 0, 0, 0), 57.07m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8249), "Fugit similique quia. Magnam cumque et recusandae et et eum consequatur. Veritatis explicabo aliquam sed voluptatum eaque repudiandae et porro aliquid.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/167.jpg", 38.061799999999998, "524 Bradtke Squares, Emersonchester, Brazil", 92.732200000000006, "North Bette", new TimeSpan(0, 10, 0, 0, 0), 35.07m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8501), "Ipsum aliquid quo quisquam dolore. Quis possimus alias consequatur dolor. Doloremque delectus aut sit aut consequuntur quod nesciunt nam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/748.jpg", -66.069100000000006, "321 Jazmin Track, Langstad, Liberia", 80.420599999999993, "Clementinaberg", new TimeSpan(0, 10, 0, 0, 0), 14.69m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8693), "Molestias ipsum soluta nisi ut voluptas iste odio fuga laborum. Explicabo dolor qui. Veniam ducimus aliquid quod sed sint. Qui repellendus soluta deserunt fugiat blanditiis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/9.jpg", -77.4328, "8595 Blick Valleys, Padbergburgh, Thailand", -56.069800000000001, "New Ron", 92.91m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8922), "Aut et enim earum voluptatum sed repellendus vel voluptas voluptatem. Est fugit soluta. Sed dolor expedita deserunt suscipit et optio voluptas doloremque. Illum illo error asperiores praesentium quia.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", 33.574100000000001, "634 Luettgen Glens, Soledadmouth, Comoros", -11.5678, "Alfordview", new TimeSpan(0, 9, 0, 0, 0), 13.04m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9119), "In sunt unde amet voluptate quaerat quia rem sed error. Odit repudiandae doloribus assumenda assumenda delectus sit vitae esse nihil. Minima omnis quia natus eos saepe eos. Vero dolor quae in non. Beatae facere tempora facere.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", 75.278700000000001, "9853 Toy Wall, West Shayleebury, Swaziland", -135.89930000000001, "Lake Gladyce", 77.86m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9360), "Et ipsa cupiditate nam sunt est a impedit nemo qui. Pariatur laboriosam omnis odio veritatis nostrum quod iusto eius et. Fuga sit sed odit voluptatem. Vel magnam ex repellendus libero aut laudantium magnam inventore. Omnis deserunt molestiae dolore magni assumenda reiciendis. Ipsum odit minus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/895.jpg", -13.5884, "021 Jaylen Junctions, Grahamtown, French Southern Territories", -78.637600000000006, "West Alexandra", new TimeSpan(0, 8, 0, 0, 0), 47.73m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9585), "Dolorem nam reprehenderit quae ut est. Beatae deleniti provident eum repellat in. Similique veritatis et cumque quae debitis rem fugit consectetur. Ut dolorem est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/222.jpg", -28.873799999999999, "038 Myrtle Prairie, Beattyland, Latvia", 25.433599999999998, "New Norbertochester", new TimeSpan(0, 8, 0, 0, 0), 44.26m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9786), "Amet dolorum voluptatem sit dolorem quo. Hic iusto ea similique sit iure. Incidunt maiores totam aut deleniti. Dicta cumque sed quos laborum ut voluptas sapiente omnis architecto. Nihil ipsam sit labore. Ad quidem omnis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1058.jpg", 20.013400000000001, "7756 Fadel Track, New Santos, Iran", 91.467299999999994, "Shieldstown", 26.68m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Sports", new DateTime(2023, 4, 27, 16, 56, 8, 588, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 6, 16, 27, 7, 855, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Music", new DateTime(2023, 4, 5, 16, 40, 33, 288, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Books", new DateTime(2023, 4, 30, 19, 17, 42, 783, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Baby", new DateTime(2023, 4, 4, 8, 4, 12, 793, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(2618), "Delectus vero accusantium suscipit id. Dolor saepe hic aut. Sed qui labore qui. Voluptatem dolorem magni.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/189.jpg", -70.805999999999997, "27330 Funk Harbor, North Nickolasborough, Indonesia", -55.874299999999998, "New Benton", 25.93m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(7064), "Ullam autem eum amet qui. Doloremque libero repellendus. Porro nihil corporis deserunt. Cupiditate sapiente aperiam saepe consequatur qui vitae eos. Quae consequatur dolores ut voluptas et sapiente aspernatur. Omnis eos corporis quod nihil voluptas ratione.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/695.jpg", -72.499700000000004, "215 Quentin Loaf, Unabury, Iceland", 27.407800000000002, "East Bernardbury", new TimeSpan(0, 9, 0, 0, 0), 75.53m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(7890), "Laborum possimus atque ducimus enim qui veniam aut qui eveniet. Placeat aut ut alias id. Dolorem fugit consectetur numquam voluptate qui sed reprehenderit quis. Soluta sit culpa quia unde est libero quia omnis eius.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/629.jpg", 77.161699999999996, "458 Skye Viaduct, Stammfurt, Palestinian Territory", -65.3874, "Jensenborough", new TimeSpan(0, 8, 0, 0, 0), 80.90m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(8311), "Ut ipsum deserunt aperiam at laudantium magni. Corrupti laboriosam aut qui velit occaecati. Quod dignissimos eum expedita perspiciatis nemo dolore. Ut omnis adipisci beatae quo fugit natus accusamus. Voluptas et voluptate modi perferendis. Aliquid voluptatem hic quis et quisquam dolor officia adipisci cupiditate.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/289.jpg", -68.506200000000007, "375 Cicero Parkway, East Aniya, Nauru", -143.35239999999999, "East Jonchester", new TimeSpan(0, 8, 0, 0, 0), 22.11m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(8768), "Sint qui fugiat. Non exercitationem aspernatur voluptatibus perspiciatis natus cum ratione alias. Laboriosam atque nesciunt est totam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/922.jpg", 47.649999999999999, "870 Morar Villages, East Madyson, Turkey", 100.9286, "West Hansmouth", 63.75m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9048), "Voluptatem eos rerum accusamus. Omnis optio dolor neque aut. Quisquam neque et labore dolore unde voluptatem ut numquam ut. Nisi dolorem recusandae qui molestiae occaecati nihil porro dolorem. Non quae cum possimus amet sint nostrum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/667.jpg", 51.094499999999996, "84974 Reynold Courts, West Bobbyview, Isle of Man", 21.2758, "Bogisichburgh", new TimeSpan(0, 8, 0, 0, 0), 58.90m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9435), "Ut labore quam. In voluptatibus voluptas consequatur sequi illo placeat qui. Est sed quidem. Rerum qui doloribus ad amet unde.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/516.jpg", 45.0486, "8964 Kilback Crossroad, North Antwon, Russian Federation", -78.163799999999995, "Dennisfort", 19.34m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9747), "Voluptas ut ad laboriosam et. Quis dolor eos et sint quidem voluptatem qui. Earum iste vero debitis error sed eaque cupiditate accusamus mollitia. Earum vitae quae. Et dolor vero possimus omnis aperiam consequatur voluptatem aspernatur. Recusandae qui quia dolor modi atque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", 43.630699999999997, "67772 Garnet Plaza, Mavericktown, Latvia", 4.0948000000000002, "Jackyborough", new TimeSpan(0, 9, 0, 0, 0), 85.08m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 492, DateTimeKind.Local).AddTicks(150), "Fugit adipisci atque voluptas nisi ut aperiam similique iusto. Ut nemo occaecati. Ut autem voluptatibus inventore quos qui. Quo et aut totam sed impedit laborum voluptatem repellendus quo. Amet quia aperiam consectetur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/347.jpg", -72.380300000000005, "741 Durward Summit, West Elveraport, Panama", 178.68440000000001, "Robelfort", new TimeSpan(0, 9, 0, 0, 0), 99.16m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 22, 28, 492, DateTimeKind.Local).AddTicks(610), "Rerum minima quia placeat sint. Necessitatibus et voluptatum aut ratione repellat sint accusantium eius. Id et et delectus doloribus magni ea. Aut maiores voluptas. Iusto quaerat quos ullam natus est autem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/370.jpg", -44.7562, "737 Burnice Turnpike, Lake Elisabeth, Mauritius", -91.150000000000006, "East Haskellberg", 78.12m });
        }
    }
}
