using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class IdentityDbContextAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(2618), "Delectus vero accusantium suscipit id. Dolor saepe hic aut. Sed qui labore qui. Voluptatem dolorem magni.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/189.jpg", -70.805999999999997, "27330 Funk Harbor, North Nickolasborough, Indonesia", -55.874299999999998, "New Benton", 25.93m });

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
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(7890), "Laborum possimus atque ducimus enim qui veniam aut qui eveniet. Placeat aut ut alias id. Dolorem fugit consectetur numquam voluptate qui sed reprehenderit quis. Soluta sit culpa quia unde est libero quia omnis eius.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/629.jpg", 77.161699999999996, "458 Skye Viaduct, Stammfurt, Palestinian Territory", -65.3874, "Jensenborough", new TimeSpan(0, 8, 0, 0, 0), 80.90m });

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
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(8768), "Sint qui fugiat. Non exercitationem aspernatur voluptatibus perspiciatis natus cum ratione alias. Laboriosam atque nesciunt est totam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/922.jpg", 47.649999999999999, "870 Morar Villages, East Madyson, Turkey", 100.9286, "West Hansmouth", new TimeSpan(0, 8, 0, 0, 0), 63.75m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9048), "Voluptatem eos rerum accusamus. Omnis optio dolor neque aut. Quisquam neque et labore dolore unde voluptatem ut numquam ut. Nisi dolorem recusandae qui molestiae occaecati nihil porro dolorem. Non quae cum possimus amet sint nostrum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/667.jpg", 51.094499999999996, "84974 Reynold Courts, West Bobbyview, Isle of Man", 21.2758, "Bogisichburgh", 58.90m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9435), "Ut labore quam. In voluptatibus voluptas consequatur sequi illo placeat qui. Est sed quidem. Rerum qui doloribus ad amet unde.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/516.jpg", 45.0486, "8964 Kilback Crossroad, North Antwon, Russian Federation", -78.163799999999995, "Dennisfort", new TimeSpan(0, 8, 0, 0, 0), 19.34m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 491, DateTimeKind.Local).AddTicks(9747), "Voluptas ut ad laboriosam et. Quis dolor eos et sint quidem voluptatem qui. Earum iste vero debitis error sed eaque cupiditate accusamus mollitia. Earum vitae quae. Et dolor vero possimus omnis aperiam consequatur voluptatem aspernatur. Recusandae qui quia dolor modi atque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", 43.630699999999997, "67772 Garnet Plaza, Mavericktown, Latvia", 4.0948000000000002, "Jackyborough", new TimeSpan(0, 9, 0, 0, 0), 85.08m });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 29, 18, 22, 28, 492, DateTimeKind.Local).AddTicks(610), "Rerum minima quia placeat sint. Necessitatibus et voluptatum aut ratione repellat sint accusantium eius. Id et et delectus doloribus magni ea. Aut maiores voluptas. Iusto quaerat quos ullam natus est autem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/370.jpg", -44.7562, "737 Burnice Turnpike, Lake Elisabeth, Mauritius", -91.150000000000006, "East Haskellberg", new TimeSpan(0, 10, 0, 0, 0), 78.12m });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Shoes", new DateTime(2023, 11, 21, 4, 37, 20, 930, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Grocery", new DateTime(2024, 1, 10, 18, 38, 19, 698, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Games", new DateTime(2023, 3, 10, 0, 8, 28, 51, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Industrial", new DateTime(2023, 1, 4, 14, 18, 6, 860, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Games", new DateTime(2024, 2, 18, 12, 21, 55, 760, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(4622), "Ab alias ipsam et facere rem repellat veniam est ut. Cupiditate voluptatum rem ab sunt voluptate sed. Ut illum est voluptas quasi ea perferendis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/130.jpg", -3.7446999999999999, "275 Shany Wells, Westborough, Latvia", -20.7972, "Kaiachester", 66.95m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(6564), "Ut ut nisi dolores hic sed in quasi facere id. Et quam nihil vel non dolorem ex blanditiis aut. Autem aut consequatur. Vel voluptates ullam in. Debitis non nihil quos rerum ut repellendus. Quas impedit odit animi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", 69.469300000000004, "206 Hammes Overpass, North Ronville, Latvia", 83.000200000000007, "Lake Lennieside", new TimeSpan(0, 8, 0, 0, 0), 84.92m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7017), "Quidem dolorem est esse et. Odio est corrupti. Ut eum veritatis. Aut quia voluptates repudiandae inventore minus. Velit architecto quia ut non.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/94.jpg", -2.0114999999999998, "23417 Hilpert Run, Runolfsdottirmouth, Central African Republic", -171.75899999999999, "Altenwerthville", new TimeSpan(0, 10, 0, 0, 0), 61.23m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7240), "Totam similique quis. Reprehenderit et doloremque. Labore molestiae necessitatibus maxime et ad et et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/36.jpg", 22.472899999999999, "70035 Richard Spring, South Maribelburgh, Isle of Man", -69.720600000000005, "New Nelsonview", new TimeSpan(0, 10, 0, 0, 0), 63.91m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7425), "Quis ipsa hic quisquam rem cumque sint. Cumque atque voluptatem et distinctio eum aliquid quisquam. Tempore dolorum iure.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/356.jpg", -24.3414, "81726 Strosin Manor, McClurechester, Bangladesh", -10.191599999999999, "Ornhaven", new TimeSpan(0, 9, 0, 0, 0), 66.24m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7605), "Similique voluptatum ex ut assumenda. Aspernatur fugit soluta aliquam molestias et perferendis voluptatem. Ut est tempora quia aut est. Ratione est molestiae eos voluptas fugiat repudiandae praesentium maxime.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/56.jpg", 23.263200000000001, "57714 Armstrong Harbors, Ralphport, Western Sahara", 178.4528, "South Monserrateberg", 39.71m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7834), "Dolore exercitationem repellendus ipsam repudiandae quia. Repudiandae hic sed quo repudiandae voluptate tenetur. Sint corporis voluptates porro aspernatur eum voluptas. Enim velit autem dolores non tempora nisi tempora iste.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/332.jpg", -10.3308, "8687 Will View, Borerbury, Japan", 171.57679999999999, "Lake Lucieshire", new TimeSpan(0, 10, 0, 0, 0), 70.14m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8046), "Laborum in consequatur minima corrupti eum tempore beatae. Accusamus totam repellendus ea debitis aut. Voluptas quia aut maiores. Quia error illum necessitatibus quas labore vero.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/594.jpg", 32.528700000000001, "36671 Wehner Junctions, Aidenside, American Samoa", 132.70820000000001, "Kuhlmanbury", new TimeSpan(0, 8, 0, 0, 0), 29.01m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8235), "Voluptatibus eos delectus eum est. Quasi vel quia nemo ea libero ipsam. Ut maiores accusamus consequatur. Quos perspiciatis quo doloremque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/572.jpg", 38.0002, "0961 Preston Dam, Port Suzanne, Japan", -17.027999999999999, "Ziemannshire", new TimeSpan(0, 8, 0, 0, 0), 69.69m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 4, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8416), "Eius omnis sit rerum rem est. Est dolores iusto architecto et nulla sapiente est illum accusamus. Alias sed laudantium error consequatur molestiae tempore eaque. Laboriosam sed nisi ea earum suscipit. Provident odit officia rerum est soluta eaque. Est adipisci eius accusantium sit accusamus nihil ipsum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/515.jpg", -39.239199999999997, "982 Vincenzo Stream, Port Theodoreview, Lesotho", -92.275700000000001, "Marquisemouth", new TimeSpan(0, 8, 0, 0, 0), 28.67m });
        }
    }
}
