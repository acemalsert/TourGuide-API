using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class userDescriptionPropertyIsMadeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 9, 9, 54, 61, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Health", new DateTime(2023, 6, 4, 21, 39, 40, 45, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Books", new DateTime(2023, 3, 25, 17, 48, 36, 598, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Home", new DateTime(2023, 5, 2, 2, 57, 24, 236, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Music", new DateTime(2024, 9, 13, 3, 21, 28, 736, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(5604), "Nostrum quia et deserunt quia aliquid molestias. At cum officiis porro dolore. Officiis ipsa omnis. Aliquid ut quia voluptatem beatae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/916.jpg", 52.787100000000002, "4587 Ortiz Circle, North Marlenshire, Burkina Faso", 173.2046, "East Olin", new TimeSpan(0, 10, 0, 0, 0), 81.04m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8030), "Placeat molestias omnis. Suscipit odit id animi magni quibusdam atque. Repellat dolor voluptatem impedit maxime sunt inventore dolor animi. Quos aspernatur molestiae nisi odit. Rerum quia iusto molestiae sit vitae provident.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/288.jpg", -66.969300000000004, "8561 Becker Islands, Federicoport, Jamaica", -2.0769000000000002, "Mauricebury", new TimeSpan(0, 9, 0, 0, 0), 26.43m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8455), "Blanditiis perspiciatis pariatur voluptas et voluptas consequatur nobis rem. Eos accusantium omnis molestias. Qui provident laboriosam molestiae ut. Non fuga quia magnam. Vitae quibusdam quaerat magnam eos at deserunt id. Aut non perspiciatis ut voluptatem est laborum nemo excepturi rerum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg", -37.703499999999998, "865 Bartoletti Via, West Deannaland, Lebanon", -45.856999999999999, "Reillyside", 58.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(152), "Aperiam et veniam iure id et porro eligendi perspiciatis. Omnis dignissimos quasi. Necessitatibus praesentium dignissimos corporis quidem tempore. Blanditiis aut omnis modi dicta corrupti nihil enim adipisci. Veritatis asperiores mollitia architecto vitae et. Doloribus id provident ipsam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/81.jpg", 67.864500000000007, "280 Christiansen Green, Clementinaburgh, South Africa", 19.017199999999999, "Mittieland", new TimeSpan(0, 9, 0, 0, 0), 76.11m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(547), "Ullam tempora maxime esse tenetur. Ipsa blanditiis cum esse. Magni repudiandae fugiat id veniam. Fugit qui dolorem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg", -48.9482, "9736 Sporer Springs, North Cheyennebury, Nepal", 178.39109999999999, "Adamston", 80.28m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(831), "Sunt alias quia nisi nemo cumque modi. Quia aut occaecati enim ipsum in aut et. Quisquam libero dignissimos. Iste aut in libero unde quis et. Quos error qui quia. Dicta qui sit facilis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", -63.603099999999998, "12238 Erdman Centers, Port Karelle, Congo", 173.72030000000001, "East Dorothyview", 7.18m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(1120), "Vitae asperiores impedit et reiciendis sit quas repudiandae nam. Et nisi sint laudantium. Et voluptas quasi nesciunt. Iste eos fuga dolorem. Aut necessitatibus suscipit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1119.jpg", 89.689700000000002, "791 Nova Mountain, South Joe, Norway", -91.505200000000002, "Ahmedmouth", 68.08m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2015), "Expedita modi soluta commodi quo delectus reprehenderit. Dolorum aut voluptatum enim molestias nisi. Architecto fugit impedit accusamus quo rem. Occaecati et rerum sunt odit nobis saepe corporis aut possimus. Dolore voluptatem ut aliquam sit tempora eum unde. Rerum incidunt est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/512.jpg", 65.177099999999996, "805 Roberto River, East Kristahaven, Dominican Republic", -30.507300000000001, "East Meredithtown", new TimeSpan(0, 9, 0, 0, 0), 45.30m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2319), "Sed possimus accusantium laudantium necessitatibus. Et quo repellat ut officia voluptatem laudantium doloremque. Voluptas harum non fuga quisquam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg", 76.496399999999994, "352 Marco Village, Medhurstshire, Afghanistan", 81.767099999999999, "Dallastown", new TimeSpan(0, 10, 0, 0, 0), 21.91m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2570), "Voluptatum sit sunt fugiat maxime reprehenderit provident asperiores autem. Blanditiis libero occaecati et cupiditate officiis reprehenderit. Porro aut sed sit dignissimos nesciunt accusamus ut. Quae natus adipisci ut cupiditate omnis dolorum. Dolor dolorem blanditiis voluptate est cupiditate at.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg", 60.304699999999997, "4601 O'Conner Ford, Port Valeriechester, Bolivia", 12.238200000000001, "Tomasview", new TimeSpan(0, 8, 0, 0, 0), 92.75m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 17, 1, 18, 32, 355, DateTimeKind.Local).AddTicks(8074));

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
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(5939), "Ratione doloremque nostrum optio illum. Repellat et odio harum et consequatur vel et quisquam. Consequuntur et dolorem voluptas numquam et tempora corporis. Repudiandae nesciunt iusto. Asperiores sed molestiae quidem recusandae eum. Nulla non dolorem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/77.jpg", 22.244199999999999, "591 Blanda Centers, East Loraland, Northern Mariana Islands", -71.397499999999994, "North Kraigmouth", new TimeSpan(0, 9, 0, 0, 0), 38.88m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(7924), "Odio officia id. Rerum ipsa ea recusandae odio beatae cumque iusto illo. Voluptate itaque eveniet excepturi saepe ratione dolor quia. Et architecto omnis voluptates aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1153.jpg", 11.8492, "361 Danika Mountains, South Jacky, Bangladesh", -91.710499999999996, "North Herbert", new TimeSpan(0, 8, 0, 0, 0), 57.07m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8249), "Fugit similique quia. Magnam cumque et recusandae et et eum consequatur. Veritatis explicabo aliquam sed voluptatum eaque repudiandae et porro aliquid.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/167.jpg", 38.061799999999998, "524 Bradtke Squares, Emersonchester, Brazil", 92.732200000000006, "North Bette", 35.07m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8501), "Ipsum aliquid quo quisquam dolore. Quis possimus alias consequatur dolor. Doloremque delectus aut sit aut consequuntur quod nesciunt nam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/748.jpg", -66.069100000000006, "321 Jazmin Track, Langstad, Liberia", 80.420599999999993, "Clementinaberg", new TimeSpan(0, 10, 0, 0, 0), 14.69m });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(8922), "Aut et enim earum voluptatum sed repellendus vel voluptas voluptatem. Est fugit soluta. Sed dolor expedita deserunt suscipit et optio voluptas doloremque. Illum illo error asperiores praesentium quia.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", 33.574100000000001, "634 Luettgen Glens, Soledadmouth, Comoros", -11.5678, "Alfordview", 13.04m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9119), "In sunt unde amet voluptate quaerat quia rem sed error. Odit repudiandae doloribus assumenda assumenda delectus sit vitae esse nihil. Minima omnis quia natus eos saepe eos. Vero dolor quae in non. Beatae facere tempora facere.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", 75.278700000000001, "9853 Toy Wall, West Shayleebury, Swaziland", -135.89930000000001, "Lake Gladyce", 77.86m });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 7, 10, 47, 29, 262, DateTimeKind.Local).AddTicks(9786), "Amet dolorum voluptatem sit dolorem quo. Hic iusto ea similique sit iure. Incidunt maiores totam aut deleniti. Dicta cumque sed quos laborum ut voluptas sapiente omnis architecto. Nihil ipsam sit labore. Ad quidem omnis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1058.jpg", 20.013400000000001, "7756 Fadel Track, New Santos, Iran", 91.467299999999994, "Shieldstown", new TimeSpan(0, 10, 0, 0, 0), 26.68m });
        }
    }
}
