using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ticketStructureAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Destinations_TourId",
                        column: x => x.TourId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Kids", new DateTime(2022, 12, 29, 6, 4, 12, 816, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Industrial", new DateTime(2024, 2, 9, 17, 30, 44, 513, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Baby", new DateTime(2023, 10, 23, 4, 53, 40, 585, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Automotive", new DateTime(2023, 11, 13, 10, 28, 36, 223, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Jewelery", new DateTime(2023, 4, 1, 12, 50, 37, 239, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 24, 17, 19, 0, 97, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 11, 24, 15, 14, 17, 161, DateTimeKind.Local).AddTicks(8767), "Quis ab quae ut assumenda non repellat non. Sed ratione enim animi voluptas mollitia. Non dolorem soluta deleniti repellat.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/430.jpg", "Riceberg", new DateTime(2024, 11, 24, 9, 19, 31, 11, DateTimeKind.Local).AddTicks(8335), 95.78m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 24, 18, 35, 15, 37, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(1434), "Quia quasi quibusdam officiis ut ipsam sunt voluptate et facilis. Et sed quibusdam quod non est. Rem omnis voluptatem voluptatem pariatur. Laudantium doloremque molestiae quis quis dolorem dolores alias error.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/716.jpg", "South Bianka", new DateTime(2024, 11, 24, 9, 38, 28, 651, DateTimeKind.Local).AddTicks(2349), 94.63m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 11, 24, 18, 42, 17, 28, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(1747), "Et omnis vel qui magni perspiciatis animi excepturi omnis. Illo consequatur nulla illum provident soluta eveniet. Provident dolorem optio natus laborum et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "South Kielfort", new DateTime(2024, 11, 24, 9, 0, 6, 539, DateTimeKind.Local).AddTicks(8480), 44.59m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 24, 18, 21, 59, 318, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(1924), "Facilis blanditiis sit. Unde ipsum et ut accusantium molestias tempora laudantium. Autem aperiam non qui reiciendis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/169.jpg", "Ashtynville", new DateTime(2024, 11, 24, 8, 39, 18, 787, DateTimeKind.Local).AddTicks(826), 17.01m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 11, 24, 18, 40, 41, 293, DateTimeKind.Local).AddTicks(4451), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(2062), "Perspiciatis minima aliquid nostrum reprehenderit commodi quas voluptas illum. Totam quasi fugiat voluptatem. Quod maiores id praesentium soluta est consectetur et dolorem. Odit omnis minus autem voluptates hic non ut soluta. Quasi consequatur incidunt voluptatem eos qui reiciendis laboriosam incidunt.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Jonesfort", new DateTime(2024, 11, 24, 9, 9, 21, 521, DateTimeKind.Local).AddTicks(7159), 68.06m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 11, 24, 18, 33, 41, 589, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(2256), "Quas adipisci perferendis id dolores vel molestias. Error aut sed est. Esse maxime non.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/975.jpg", "North Schuyler", new DateTime(2024, 11, 24, 9, 52, 10, 443, DateTimeKind.Local).AddTicks(4604), 29.46m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 11, 24, 18, 37, 6, 7, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(2366), "Omnis qui culpa et. Praesentium qui alias eum est vel itaque placeat et ullam. Repellendus nihil deserunt tempora ad quasi nemo et sed nisi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/112.jpg", "New Zackland", new DateTime(2024, 11, 24, 8, 12, 51, 377, DateTimeKind.Local).AddTicks(4974), 40.16m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 24, 18, 47, 3, 633, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(2689), "Voluptas reprehenderit et. Perferendis voluptatem aut sit omnis. Animi omnis dolor corrupti eos aut nesciunt occaecati. Sunt aut at occaecati natus accusamus molestiae. Exercitationem nobis aut et necessitatibus nobis necessitatibus itaque et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/181.jpg", "New Kendall", new DateTime(2024, 11, 24, 9, 48, 59, 338, DateTimeKind.Local).AddTicks(2853), 84.85m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 36, 14, 442, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(2978), "Doloremque laborum a voluptas nisi porro quidem ut at. Aut aperiam voluptatibus natus earum. Fugiat blanditiis illo voluptates officiis incidunt aspernatur est. Eveniet velit aut. Placeat qui sed sunt ea.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1102.jpg", "Marilouside", new DateTime(2024, 11, 24, 8, 24, 22, 672, DateTimeKind.Local).AddTicks(3825), 36.94m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new DateTime(2024, 11, 24, 17, 53, 27, 156, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 11, 24, 15, 14, 17, 162, DateTimeKind.Local).AddTicks(3128), "Architecto ab et nihil rerum est officia. Dolore id nostrum ut esse cum soluta ipsum ex. Quod voluptatem quis est sint reiciendis dolorem eaque ut. Beatae vel voluptatem quidem omnis nostrum suscipit dicta aliquid. Consectetur in neque reprehenderit tempore voluptatum accusamus omnis qui esse.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/90.jpg", "Hagenesberg", new DateTime(2024, 11, 24, 8, 51, 3, 667, DateTimeKind.Local).AddTicks(9221), 42.47m });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PaymentId",
                table: "Tickets",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TourId",
                table: "Tickets",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Payments");

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
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Garden", new DateTime(2022, 11, 23, 20, 19, 14, 1, DateTimeKind.Local).AddTicks(3187) });

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
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 11, 1, 18, 19, 4, 511, DateTimeKind.Local).AddTicks(1211), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5436), "Qui vero quibusdam reprehenderit fugit et. Est perspiciatis corporis corrupti qui. Sit dolorem commodi deleniti ducimus voluptas quia est laudantium. Optio nemo incidunt consectetur voluptatem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/681.jpg", "Raeside", new DateTime(2024, 11, 1, 8, 51, 56, 459, DateTimeKind.Local).AddTicks(765), 24.39m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 11, 1, 17, 31, 16, 865, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5554), "Aliquam minus officiis in nulla dolor magni culpa molestiae. Totam dolor repellendus voluptatem. Nesciunt exercitationem quaerat eius assumenda eveniet quia molestiae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Port Haleighmouth", new DateTime(2024, 11, 1, 8, 1, 33, 204, DateTimeKind.Local).AddTicks(8019), 72.53m });

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
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 11, 1, 18, 38, 13, 624, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6074), "Pariatur perferendis assumenda error dolore quia. Consectetur id deleniti ab rerum non aperiam. Id dolorem qui a et omnis enim nihil. Sunt et quia ipsa est animi architecto reprehenderit quia iste. Ipsa molestiae deserunt aut corporis magni fugiat et tenetur explicabo.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1093.jpg", "Connerchester", new DateTime(2024, 11, 1, 9, 53, 11, 632, DateTimeKind.Local).AddTicks(8939), 15.58m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageData", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new DateTime(2024, 11, 1, 18, 8, 35, 595, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6215), "Eveniet quia laboriosam accusantium. Voluptate quam nesciunt earum modi magni autem. Tempora ea maiores impedit. Nisi sapiente deserunt. Eveniet repudiandae voluptatum recusandae. Nemo iusto explicabo.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "South Horaceborough", new DateTime(2024, 11, 1, 9, 52, 31, 811, DateTimeKind.Local).AddTicks(7456), 82.71m });
        }
    }
}
