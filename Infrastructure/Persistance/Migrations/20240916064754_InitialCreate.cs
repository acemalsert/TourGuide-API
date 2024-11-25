using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "Shoes", new DateTime(2023, 11, 21, 4, 37, 20, 930, DateTimeKind.Local).AddTicks(1237), false },
                    { 2, "Grocery", new DateTime(2024, 1, 10, 18, 38, 19, 698, DateTimeKind.Local).AddTicks(6705), false },
                    { 3, "Games", new DateTime(2023, 3, 10, 0, 8, 28, 51, DateTimeKind.Local).AddTicks(9869), false },
                    { 4, "Industrial", new DateTime(2023, 1, 4, 14, 18, 6, 860, DateTimeKind.Local).AddTicks(8848), false },
                    { 5, "Games", new DateTime(2024, 2, 18, 12, 21, 55, 760, DateTimeKind.Local).AddTicks(1283), false }
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(4622), "Ab alias ipsam et facere rem repellat veniam est ut. Cupiditate voluptatum rem ab sunt voluptate sed. Ut illum est voluptas quasi ea perferendis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/130.jpg", false, -3.7446999999999999, "275 Shany Wells, Westborough, Latvia", -20.7972, "Kaiachester", new TimeSpan(0, 9, 0, 0, 0), 66.95m },
                    { 2, 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(6564), "Ut ut nisi dolores hic sed in quasi facere id. Et quam nihil vel non dolorem ex blanditiis aut. Autem aut consequatur. Vel voluptates ullam in. Debitis non nihil quos rerum ut repellendus. Quas impedit odit animi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", false, 69.469300000000004, "206 Hammes Overpass, North Ronville, Latvia", 83.000200000000007, "Lake Lennieside", new TimeSpan(0, 8, 0, 0, 0), 84.92m },
                    { 3, 4, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7017), "Quidem dolorem est esse et. Odio est corrupti. Ut eum veritatis. Aut quia voluptates repudiandae inventore minus. Velit architecto quia ut non.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/94.jpg", false, -2.0114999999999998, "23417 Hilpert Run, Runolfsdottirmouth, Central African Republic", -171.75899999999999, "Altenwerthville", new TimeSpan(0, 10, 0, 0, 0), 61.23m },
                    { 4, 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7240), "Totam similique quis. Reprehenderit et doloremque. Labore molestiae necessitatibus maxime et ad et et.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/36.jpg", false, 22.472899999999999, "70035 Richard Spring, South Maribelburgh, Isle of Man", -69.720600000000005, "New Nelsonview", new TimeSpan(0, 10, 0, 0, 0), 63.91m },
                    { 5, 1, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7425), "Quis ipsa hic quisquam rem cumque sint. Cumque atque voluptatem et distinctio eum aliquid quisquam. Tempore dolorum iure.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/356.jpg", false, -24.3414, "81726 Strosin Manor, McClurechester, Bangladesh", -10.191599999999999, "Ornhaven", new TimeSpan(0, 9, 0, 0, 0), 66.24m },
                    { 6, 3, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7605), "Similique voluptatum ex ut assumenda. Aspernatur fugit soluta aliquam molestias et perferendis voluptatem. Ut est tempora quia aut est. Ratione est molestiae eos voluptas fugiat repudiandae praesentium maxime.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/56.jpg", false, 23.263200000000001, "57714 Armstrong Harbors, Ralphport, Western Sahara", 178.4528, "South Monserrateberg", new TimeSpan(0, 8, 0, 0, 0), 39.71m },
                    { 7, 5, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(7834), "Dolore exercitationem repellendus ipsam repudiandae quia. Repudiandae hic sed quo repudiandae voluptate tenetur. Sint corporis voluptates porro aspernatur eum voluptas. Enim velit autem dolores non tempora nisi tempora iste.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/332.jpg", false, -10.3308, "8687 Will View, Borerbury, Japan", 171.57679999999999, "Lake Lucieshire", new TimeSpan(0, 10, 0, 0, 0), 70.14m },
                    { 8, 4, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8046), "Laborum in consequatur minima corrupti eum tempore beatae. Accusamus totam repellendus ea debitis aut. Voluptas quia aut maiores. Quia error illum necessitatibus quas labore vero.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/594.jpg", false, 32.528700000000001, "36671 Wehner Junctions, Aidenside, American Samoa", 132.70820000000001, "Kuhlmanbury", new TimeSpan(0, 8, 0, 0, 0), 29.01m },
                    { 9, 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8235), "Voluptatibus eos delectus eum est. Quasi vel quia nemo ea libero ipsam. Ut maiores accusamus consequatur. Quos perspiciatis quo doloremque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/572.jpg", false, 38.0002, "0961 Preston Dam, Port Suzanne, Japan", -17.027999999999999, "Ziemannshire", new TimeSpan(0, 8, 0, 0, 0), 69.69m },
                    { 10, 4, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 9, 16, 9, 47, 54, 301, DateTimeKind.Local).AddTicks(8416), "Eius omnis sit rerum rem est. Est dolores iusto architecto et nulla sapiente est illum accusamus. Alias sed laudantium error consequatur molestiae tempore eaque. Laboriosam sed nisi ea earum suscipit. Provident odit officia rerum est soluta eaque. Est adipisci eius accusantium sit accusamus nihil ipsum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/515.jpg", false, -39.239199999999997, "982 Vincenzo Stream, Port Theodoreview, Lesotho", -92.275700000000001, "Marquisemouth", new TimeSpan(0, 8, 0, 0, 0), 28.67m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_CategoryId",
                table: "Destinations",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
