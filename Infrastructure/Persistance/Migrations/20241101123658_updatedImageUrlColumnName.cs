using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updatedImageUrlColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Destinations",
                newName: "ImageData");

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
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Garden", new DateTime(2023, 6, 7, 16, 18, 36, 80, DateTimeKind.Local).AddTicks(7881) });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 310, DateTimeKind.Local).AddTicks(9493), "In ipsam alias porro. Ullam quasi aut qui est et adipisci placeat architecto. Autem soluta placeat ut quis itaque reprehenderit ipsam praesentium.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/186.jpg", "Monicafort", 80.67m });

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
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1328), "Sunt aut voluptas facere aut cum error molestiae est. Eum corporis totam necessitatibus unde. Et expedita qui. Sequi incidunt et illo tempore aut omnis dolorum in. Atque nostrum repellat incidunt quasi quo facere ipsam molestiae dolorum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/784.jpg", "West Uriah", new TimeSpan(0, 10, 0, 0, 0), 16.02m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1487), "Voluptatum possimus id ea at vero. Natus animi ratione corrupti iste magni. Maiores rerum sit hic labore repellendus eum qui non. Ut a quia. Inventore voluptatem ducimus perspiciatis at.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1100.jpg", "Jerdechester", new TimeSpan(0, 9, 0, 0, 0), 62.58m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1641), "Facere rerum qui adipisci odit ipsum reiciendis laborum et. Aliquid nulla error fugit provident numquam et. Repudiandae cum perferendis eveniet nihil molestiae labore voluptatibus voluptas. Sed omnis ut aut et unde nihil. Ea omnis temporibus nam et et quia alias aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/774.jpg", "Jermeymouth", new TimeSpan(0, 10, 0, 0, 0), 28.39m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1811), "Consequatur vero praesentium nam et. Doloremque laborum sit id repellat at dolor in. Omnis sunt in impedit delectus commodi reprehenderit omnis omnis nihil. Rerum minima laborum animi labore error ut. Modi eaque sit amet amet fugit enim. Aut et impedit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1146.jpg", "North Clementview", new TimeSpan(0, 9, 0, 0, 0), 19.26m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(1974), "Voluptas eos aut enim excepturi natus iusto veritatis. Consequatur ipsa vel necessitatibus. Ut tempore voluptatum sunt mollitia.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/471.jpg", "Goodwinmouth", new TimeSpan(0, 9, 0, 0, 0), 69.58m });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(2186), "Alias delectus omnis natus quis voluptatem quis aliquam. Non accusamus in cumque accusamus et accusantium nam. Omnis fugit commodi consequuntur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1223.jpg", "Celineville", 90.67m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 11, 1, 15, 36, 58, 311, DateTimeKind.Local).AddTicks(2260), "Aut totam doloremque. Expedita vitae velit nihil qui dolorem. Commodi voluptas ipsa amet impedit eligendi quod hic architecto.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/911.jpg", "Port Ferne", new TimeSpan(0, 10, 0, 0, 0), 52.71m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Destinations",
                newName: "ImageUrl");

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
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Kids", new DateTime(2022, 12, 27, 13, 10, 20, 361, DateTimeKind.Local).AddTicks(3701) });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(2836), "Magni ut impedit dolor itaque. Occaecati excepturi at enim expedita veritatis voluptatibus fugiat et voluptates. Qui velit quae veritatis. Ut cum quos qui fugiat sed. Libero nulla voluptas facilis cupiditate voluptas nostrum qui accusamus. Sapiente ut amet ut et aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/264.jpg", "Natashaborough", 10.72m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4381), "Quod voluptatem quia dolorem. Voluptatem voluptas possimus quod quibusdam quia quos nam sit. Aut voluptatem distinctio sunt ut alias suscipit incidunt. Id provident consequuntur perferendis pariatur mollitia adipisci iste numquam sit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/317.jpg", "Mariannefort", new TimeSpan(0, 9, 0, 0, 0), 90.87m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4615), "Voluptates error aut est. Dolores vitae in hic. Repellat quas quo cupiditate nostrum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1086.jpg", "South Casey", new TimeSpan(0, 9, 0, 0, 0), 43.87m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4722), "Quo id aut voluptas delectus tempore eaque officia. Eum aliquid consequatur. Ut rerum quia. Sapiente maiores ut sed non reiciendis. Aspernatur aut magni. Qui quis fuga.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/866.jpg", "Thielbury", new TimeSpan(0, 8, 0, 0, 0), 23.85m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4835), "Consequuntur sapiente magnam officiis velit ex perspiciatis consectetur. Voluptate ut nemo aut eius nihil laborum dignissimos veniam. Quasi reiciendis quos. Doloribus voluptatem est. Nobis sapiente labore et exercitationem est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Lilaville", new TimeSpan(0, 8, 0, 0, 0), 62.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(4955), "Explicabo libero aut architecto laboriosam quo. Optio laboriosam et cupiditate iure corrupti in qui. Dolores fugiat impedit qui.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/437.jpg", "North Misty", new TimeSpan(0, 8, 0, 0, 0), 85.36m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5066), "Velit deleniti voluptatem esse aperiam facere cumque natus et. A excepturi voluptatem aut reiciendis rerum omnis earum et. Cum enim aut sit aperiam dolores ut accusamus sapiente totam. Quo eaque odit sed repudiandae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/422.jpg", "North Annamarie", new TimeSpan(0, 8, 0, 0, 0), 76.60m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5199), "Quidem molestiae expedita aliquam ratione omnis soluta tenetur sint deserunt. Ab sit mollitia doloremque dolorum dolorem similique. Deleniti laudantium iste excepturi necessitatibus repellendus ex quam fuga. Unde voluptas eos. Natus quia provident. Illo eos ut eaque unde consequuntur ad maiores est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/854.jpg", "Wilfredmouth", new TimeSpan(0, 8, 0, 0, 0), 51.64m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5352), "Consectetur rerum alias dolor facilis iure quibusdam. Quibusdam soluta repellendus incidunt. Et nisi veniam tenetur tempora dignissimos ut perspiciatis architecto. Laudantium voluptas harum ut. Nam soluta illo tempore quia corrupti.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/422.jpg", "Port Citlalli", 81.24m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 11, 1, 15, 26, 3, 869, DateTimeKind.Local).AddTicks(5491), "Aspernatur est voluptas eos. Omnis maiores enim ut dolores voluptas officiis et ullam. Ut facere distinctio quia. Ullam consequuntur aut fugit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/149.jpg", "Priceshire", new TimeSpan(0, 9, 0, 0, 0), 30.42m });
        }
    }
}
