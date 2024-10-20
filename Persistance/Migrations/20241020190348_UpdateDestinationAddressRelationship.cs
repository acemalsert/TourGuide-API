using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDestinationAddressRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DestinationAddresses",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationAddresses", x => new { x.DestinationId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_DestinationAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinationAddresses_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Kids", new DateTime(2024, 7, 20, 7, 32, 51, 914, DateTimeKind.Local).AddTicks(2202) });

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
                columns: new[] { "AddressId", "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, 2, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(546), "Consequatur hic commodi sapiente sed excepturi error. Et esse dolorem quisquam id dicta sequi. Ipsa ut aperiam id vel tenetur libero corporis. Consequatur eum consequatur ullam eaque ut quo quisquam dolor corporis. Omnis voluptates optio aliquid ipsum enim voluptatem dolorem beatae consequatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/369.jpg", -65.055199999999999, "86447 Streich Mountain, Lake Neldahaven, Egypt", 90.253200000000007, "East Havenland", new TimeSpan(0, 8, 0, 0, 0), 22.69m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, 1, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(3415), "Sunt dolorem perferendis molestiae illo quia. Repellat dolore laudantium debitis. Debitis dolore quia. Molestias hic ut beatae animi. Natus cupiditate omnis voluptas reiciendis unde.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/256.jpg", -16.765799999999999, "419 Donnelly Shoal, North Joeyhaven, Iceland", -33.119700000000002, "Romaguerachester", new TimeSpan(0, 8, 0, 0, 0), 27.05m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(3918), "Aut voluptas voluptate quis vel. Fugit consequatur rem alias. Ipsam sit aliquid et ducimus omnis. Perspiciatis earum nam reiciendis. Dignissimos aut praesentium rerum aliquid et. Consequatur rerum amet et deserunt et sunt mollitia non.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/272.jpg", 73.547799999999995, "722 Pfannerstill Glens, Port Katrina, Uruguay", -5.8022, "Brannonborough", new TimeSpan(0, 9, 0, 0, 0), 85.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, 3, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4264), "Est excepturi totam animi. Sunt id est voluptatem. Harum maxime expedita minus voluptatum animi. Possimus molestias voluptatem exercitationem. Ad quia voluptas. Molestiae vero adipisci.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/271.jpg", 53.741799999999998, "44049 Smith Burg, West Hailey, Ethiopia", -144.8646, "Wunschfort", new TimeSpan(0, 10, 0, 0, 0), 32.92m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, 5, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4543), "Rerum ipsam non dolores id. Omnis excepturi tempore dicta. Minus est ex eligendi sit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/153.jpg", -77.568700000000007, "0028 Kaden Hill, North Kendra, Latvia", 36.471499999999999, "Port Fanny", new TimeSpan(0, 9, 0, 0, 0), 53.47m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressId", "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { null, 2, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(4774), "Cumque dolore voluptatibus explicabo maiores consequuntur molestiae repellendus. Sapiente ea vero voluptas in nemo. Architecto quibusdam ab.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/666.jpg", -25.367999999999999, "952 Rita Corner, Athenaville, Guyana", -175.88300000000001, "Klockoland", 49.80m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { null, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5000), "Minus sit similique quia et praesentium reiciendis voluptatum rerum sit. Minus saepe aut consequatur molestiae mollitia in quaerat nihil velit. Quo totam at asperiores inventore. In perspiciatis asperiores amet quia qui mollitia est accusantium natus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/436.jpg", 78.963300000000004, "48494 Legros Hollow, East Vanceton, Brunei Darussalam", -173.56049999999999, "O'Connerside", 23.67m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressId", "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, 4, new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5367), "Omnis incidunt nihil earum. Sapiente ut sed nihil molestiae. Suscipit veniam exercitationem tenetur omnis quasi cumque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1180.jpg", 89.818200000000004, "2175 Juliana Valley, Zoramouth, Maldives", -83.902199999999993, "Port Devin", new TimeSpan(0, 10, 0, 0, 0), 47.19m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { null, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(5598), "Voluptatem modi eveniet itaque molestiae. Occaecati ab odit ex tenetur deserunt quo et ut qui. Tenetur consequatur nihil ut excepturi quas velit culpa in modi. Ullam neque ex natus porro beatae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1009.jpg", -61.986400000000003, "28231 Audra Burgs, Veumshire, Nigeria", -32.0503, "South Breanna", new TimeSpan(0, 9, 0, 0, 0), 97.25m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { null, new DateTime(2024, 10, 20, 22, 3, 48, 569, DateTimeKind.Local).AddTicks(6162), "Qui modi odit minima sunt minima tempora. Praesentium ab ut nihil maxime dolores earum aut tempore rem. Voluptas dolor est et tenetur voluptatem ab dignissimos. Voluptates quas vel tempora quia blanditiis pariatur laborum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", -48.005499999999998, "894 Gerhard Corner, Nathenmouth, Bosnia and Herzegovina", -141.5506, "Kuvalisbury", 94.74m });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_AddressId",
                table: "Destinations",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationAddresses_AddressId",
                table: "DestinationAddresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Addresses_AddressId",
                table: "Destinations",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Addresses_AddressId",
                table: "Destinations");

            migrationBuilder.DropTable(
                name: "DestinationAddresses");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_AddressId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Destinations");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Beauty", new DateTime(2024, 4, 29, 9, 9, 54, 61, DateTimeKind.Local).AddTicks(2961) });

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
                columns: new[] { "CategoryId", "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(5604), "Nostrum quia et deserunt quia aliquid molestias. At cum officiis porro dolore. Officiis ipsa omnis. Aliquid ut quia voluptatem beatae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/916.jpg", 52.787100000000002, "4587 Ortiz Circle, North Marlenshire, Burkina Faso", 173.2046, "East Olin", new TimeSpan(0, 10, 0, 0, 0), 81.04m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8030), "Placeat molestias omnis. Suscipit odit id animi magni quibusdam atque. Repellat dolor voluptatem impedit maxime sunt inventore dolor animi. Quos aspernatur molestiae nisi odit. Rerum quia iusto molestiae sit vitae provident.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/288.jpg", -66.969300000000004, "8561 Becker Islands, Federicoport, Jamaica", -2.0769000000000002, "Mauricebury", new TimeSpan(0, 9, 0, 0, 0), 26.43m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8455), "Blanditiis perspiciatis pariatur voluptas et voluptas consequatur nobis rem. Eos accusantium omnis molestias. Qui provident laboriosam molestiae ut. Non fuga quia magnam. Vitae quibusdam quaerat magnam eos at deserunt id. Aut non perspiciatis ut voluptatem est laborum nemo excepturi rerum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg", -37.703499999999998, "865 Bartoletti Via, West Deannaland, Lebanon", -45.856999999999999, "Reillyside", new TimeSpan(0, 10, 0, 0, 0), 58.49m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 5, new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(152), "Aperiam et veniam iure id et porro eligendi perspiciatis. Omnis dignissimos quasi. Necessitatibus praesentium dignissimos corporis quidem tempore. Blanditiis aut omnis modi dicta corrupti nihil enim adipisci. Veritatis asperiores mollitia architecto vitae et. Doloribus id provident ipsam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/81.jpg", 67.864500000000007, "280 Christiansen Green, Clementinaburgh, South Africa", 19.017199999999999, "Mittieland", new TimeSpan(0, 9, 0, 0, 0), 76.11m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { 1, new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(547), "Ullam tempora maxime esse tenetur. Ipsa blanditiis cum esse. Magni repudiandae fugiat id veniam. Fugit qui dolorem.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg", -48.9482, "9736 Sporer Springs, North Cheyennebury, Nepal", 178.39109999999999, "Adamston", new TimeSpan(0, 8, 0, 0, 0), 80.28m });

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
                columns: new[] { "ClosingTime", "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(1120), "Vitae asperiores impedit et reiciendis sit quas repudiandae nam. Et nisi sint laudantium. Et voluptas quasi nesciunt. Iste eos fuga dolorem. Aut necessitatibus suscipit.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1119.jpg", 89.689700000000002, "791 Nova Mountain, South Joe, Norway", -91.505200000000002, "Ahmedmouth", 68.08m });

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
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "OpeningTime", "TicketPrice" },
                values: new object[] { new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2319), "Sed possimus accusantium laudantium necessitatibus. Et quo repellat ut officia voluptatem laudantium doloremque. Voluptas harum non fuga quisquam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg", 76.496399999999994, "352 Marco Village, Medhurstshire, Afghanistan", 81.767099999999999, "Dallastown", new TimeSpan(0, 10, 0, 0, 0), 21.91m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Latitude", "Location", "Longitude", "Name", "TicketPrice" },
                values: new object[] { new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2570), "Voluptatum sit sunt fugiat maxime reprehenderit provident asperiores autem. Blanditiis libero occaecati et cupiditate officiis reprehenderit. Porro aut sed sit dignissimos nesciunt accusamus ut. Quae natus adipisci ut cupiditate omnis dolorum. Dolor dolorem blanditiis voluptate est cupiditate at.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg", 60.304699999999997, "4601 O'Conner Ford, Port Valeriechester, Bolivia", 12.238200000000001, "Tomasview", 92.75m });
        }
    }
}
