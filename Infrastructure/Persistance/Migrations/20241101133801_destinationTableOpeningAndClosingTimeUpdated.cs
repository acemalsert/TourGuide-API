using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class destinationTableOpeningAndClosingTimeUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpeningTime",
                table: "Destinations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingTime",
                table: "Destinations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Computers", new DateTime(2024, 2, 21, 4, 22, 31, 536, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Sports", new DateTime(2023, 1, 8, 9, 7, 59, 119, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Music", new DateTime(2024, 1, 10, 19, 9, 49, 9, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 23, 20, 19, 14, 1, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Games", new DateTime(2023, 7, 28, 7, 16, 48, 94, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 11, 1, 18, 6, 35, 918, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(3218), "Veniam quod quisquam mollitia magni tenetur occaecati tenetur. Sapiente qui quos ipsam qui soluta numquam eos voluptatem qui. Necessitatibus et voluptas aut animi consequatur at vel cum repudiandae. Ut rerum quae quia quis. Fugit commodi assumenda accusantium omnis unde itaque ut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/342.jpg", "Harveyport", new DateTime(2024, 11, 1, 9, 1, 21, 114, DateTimeKind.Local).AddTicks(7856), 49.98m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 11, 1, 18, 33, 51, 449, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(4811), "Officia et animi aspernatur fugit. Nisi non magnam. Sit et error inventore. Sed unde aut maxime odio facere quaerat. Consequuntur aut et ea veritatis aperiam earum cumque sint facilis. Alias doloremque expedita.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/773.jpg", "Anastaciofort", new DateTime(2024, 11, 1, 9, 18, 12, 857, DateTimeKind.Local).AddTicks(6969), 44.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 11, 1, 18, 13, 6, 655, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5085), "Delectus quia sequi reprehenderit sint. Perferendis et minus nobis ipsum aperiam voluptatem quidem architecto ut. Consectetur in voluptatem itaque eveniet. Et suscipit eligendi earum. Dolorum corrupti quo sapiente recusandae a vitae. Et enim voluptatibus iure aut neque qui cum ut suscipit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/754.jpg", "Penelopetown", new DateTime(2024, 11, 1, 8, 25, 32, 767, DateTimeKind.Local).AddTicks(1054), 24.65m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 11, 1, 17, 7, 53, 38, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5269), "Adipisci maiores cum magni accusamus sit quae sed sunt. Dignissimos distinctio corrupti architecto et blanditiis fugiat beatae qui eos. Expedita quo cumque a autem. Nihil sequi eum mollitia quo et ut adipisci et. Quo neque suscipit incidunt assumenda esse vel molestiae molestias. Voluptatibus porro modi modi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/860.jpg", "Charitystad", new DateTime(2024, 11, 1, 9, 34, 51, 691, DateTimeKind.Local).AddTicks(1834), 24.83m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 1, 18, 19, 4, 511, DateTimeKind.Local).AddTicks(1211), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5436), "Qui vero quibusdam reprehenderit fugit et. Est perspiciatis corporis corrupti qui. Sit dolorem commodi deleniti ducimus voluptas quia est laudantium. Optio nemo incidunt consectetur voluptatem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/681.jpg", "Raeside", new DateTime(2024, 11, 1, 8, 51, 56, 459, DateTimeKind.Local).AddTicks(765), 24.39m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 11, 1, 17, 31, 16, 865, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5554), "Aliquam minus officiis in nulla dolor magni culpa molestiae. Totam dolor repellendus voluptatem. Nesciunt exercitationem quaerat eius assumenda eveniet quia molestiae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Port Haleighmouth", new DateTime(2024, 11, 1, 8, 1, 33, 204, DateTimeKind.Local).AddTicks(8019), 72.53m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 11, 1, 18, 51, 48, 420, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5729), "Et tenetur accusamus exercitationem mollitia debitis vitae ut nobis ut. Aut suscipit quae sint commodi deserunt et dolorem qui quo. Autem velit aut. Quae reiciendis porro sit ad corporis. Ipsam eum eveniet aliquid qui in.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1090.jpg", "North Glen", new DateTime(2024, 11, 1, 9, 7, 34, 688, DateTimeKind.Local).AddTicks(6344), 27.19m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 11, 1, 18, 30, 13, 238, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5887), "Facilis esse dolore quod voluptatibus. Natus est fugiat minima dignissimos quas cumque et excepturi sunt. Est autem totam hic repellendus expedita deleniti qui. Et ex aut vitae temporibus sed. Et quia vel expedita earum dolore facilis est. Voluptatum nam saepe officia doloribus sunt.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1078.jpg", "Terryland", new DateTime(2024, 11, 1, 8, 22, 34, 611, DateTimeKind.Local).AddTicks(3664), 71.32m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 1, 18, 38, 13, 624, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6074), "Pariatur perferendis assumenda error dolore quia. Consectetur id deleniti ab rerum non aperiam. Id dolorem qui a et omnis enim nihil. Sunt et quia ipsa est animi architecto reprehenderit quia iste. Ipsa molestiae deserunt aut corporis magni fugiat et tenetur explicabo.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1093.jpg", "Connerchester", new DateTime(2024, 11, 1, 9, 53, 11, 632, DateTimeKind.Local).AddTicks(8939), 15.58m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 11, 1, 18, 8, 35, 595, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6215), "Eveniet quia laboriosam accusantium. Voluptate quam nesciunt earum modi magni autem. Tempora ea maiores impedit. Nisi sapiente deserunt. Eveniet repudiandae voluptatum recusandae. Nemo iusto explicabo.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "South Horaceborough", new DateTime(2024, 11, 1, 9, 52, 31, 811, DateTimeKind.Local).AddTicks(7456), 82.71m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Destinations",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Destinations",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Books", new DateTime(2024, 1, 10, 6, 20, 32, 517, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Garden", new DateTime(2023, 9, 18, 11, 55, 39, 762, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Computers", new DateTime(2023, 2, 5, 21, 1, 18, 790, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 16, 18, 36, 80, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Computers", new DateTime(2023, 8, 12, 12, 49, 51, 359, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 310, DateTimeKind.Local).AddTicks(9493), "In ipsam alias porro. Ullam quasi aut qui est et adipisci placeat architecto. Autem soluta placeat ut quis itaque reprehenderit ipsam praesentium.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/186.jpg", "Monicafort", new TimeSpan(0, 10, 0, 0, 0), 80.67m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1085), "Explicabo natus odio velit omnis. Quam explicabo dolor molestiae deserunt. Dolor molestias mollitia perspiciatis maxime suscipit quia sint. Deserunt sunt nulla corrupti voluptatum dolorem. Perspiciatis nulla eveniet voluptas quisquam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Mullershire", new TimeSpan(0, 10, 0, 0, 0), 54.32m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1328), "Sunt aut voluptas facere aut cum error molestiae est. Eum corporis totam necessitatibus unde. Et expedita qui. Sequi incidunt et illo tempore aut omnis dolorum in. Atque nostrum repellat incidunt quasi quo facere ipsam molestiae dolorum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/784.jpg", "West Uriah", new TimeSpan(0, 10, 0, 0, 0), 16.02m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1487), "Voluptatum possimus id ea at vero. Natus animi ratione corrupti iste magni. Maiores rerum sit hic labore repellendus eum qui non. Ut a quia. Inventore voluptatem ducimus perspiciatis at.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1100.jpg", "Jerdechester", new TimeSpan(0, 9, 0, 0, 0), 62.58m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1641), "Facere rerum qui adipisci odit ipsum reiciendis laborum et. Aliquid nulla error fugit provident numquam et. Repudiandae cum perferendis eveniet nihil molestiae labore voluptatibus voluptas. Sed omnis ut aut et unde nihil. Ea omnis temporibus nam et et quia alias aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/774.jpg", "Jermeymouth", new TimeSpan(0, 10, 0, 0, 0), 28.39m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1811), "Consequatur vero praesentium nam et. Doloremque laborum sit id repellat at dolor in. Omnis sunt in impedit delectus commodi reprehenderit omnis omnis nihil. Rerum minima laborum animi labore error ut. Modi eaque sit amet amet fugit enim. Aut et impedit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1146.jpg", "North Clementview", new TimeSpan(0, 9, 0, 0, 0), 19.26m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1974), "Voluptas eos aut enim excepturi natus iusto veritatis. Consequatur ipsa vel necessitatibus. Ut tempore voluptatum sunt mollitia.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/471.jpg", "Goodwinmouth", new TimeSpan(0, 9, 0, 0, 0), 69.58m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(2073), "Nihil hic veniam et qui consequatur nemo quo incidunt. Commodi qui iure et eos at odit omnis. Laboriosam voluptatem consectetur sed accusamus rerum enim ducimus animi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1000.jpg", "Noeliashire", new TimeSpan(0, 9, 0, 0, 0), 79.56m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(2186), "Alias delectus omnis natus quis voluptatem quis aliquam. Non accusamus in cumque accusamus et accusantium nam. Omnis fugit commodi consequuntur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1223.jpg", "Celineville", new TimeSpan(0, 9, 0, 0, 0), 90.67m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(2260), "Aut totam doloremque. Expedita vitae velit nihil qui dolorem. Commodi voluptas ipsa amet impedit eligendi quod hic architecto.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/911.jpg", "Port Ferne", new TimeSpan(0, 10, 0, 0, 0), 52.71m });
        }
    }
}
