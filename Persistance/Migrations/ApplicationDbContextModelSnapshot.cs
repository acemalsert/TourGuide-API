﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourGuide.Persistance.Context;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Beauty",
                            CreatedDate = new DateTime(2024, 4, 29, 9, 9, 54, 61, DateTimeKind.Local).AddTicks(2961),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Health",
                            CreatedDate = new DateTime(2023, 6, 4, 21, 39, 40, 45, DateTimeKind.Local).AddTicks(9262),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Books",
                            CreatedDate = new DateTime(2023, 3, 25, 17, 48, 36, 598, DateTimeKind.Local).AddTicks(5300),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2023, 5, 2, 2, 57, 24, 236, DateTimeKind.Local).AddTicks(4853),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Music",
                            CreatedDate = new DateTime(2024, 9, 13, 3, 21, 28, 736, DateTimeKind.Local).AddTicks(7676),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Domain.Entities.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("time");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(5604),
                            Description = "Nostrum quia et deserunt quia aliquid molestias. At cum officiis porro dolore. Officiis ipsa omnis. Aliquid ut quia voluptatem beatae.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/916.jpg",
                            IsDeleted = false,
                            Latitude = 52.787100000000002,
                            Location = "4587 Ortiz Circle, North Marlenshire, Burkina Faso",
                            Longitude = 173.2046,
                            Name = "East Olin",
                            OpeningTime = new TimeSpan(0, 10, 0, 0, 0),
                            TicketPrice = 81.04m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            ClosingTime = new TimeSpan(0, 17, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8030),
                            Description = "Placeat molestias omnis. Suscipit odit id animi magni quibusdam atque. Repellat dolor voluptatem impedit maxime sunt inventore dolor animi. Quos aspernatur molestiae nisi odit. Rerum quia iusto molestiae sit vitae provident.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/288.jpg",
                            IsDeleted = false,
                            Latitude = -66.969300000000004,
                            Location = "8561 Becker Islands, Federicoport, Jamaica",
                            Longitude = -2.0769000000000002,
                            Name = "Mauricebury",
                            OpeningTime = new TimeSpan(0, 9, 0, 0, 0),
                            TicketPrice = 26.43m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            ClosingTime = new TimeSpan(0, 18, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 344, DateTimeKind.Local).AddTicks(8455),
                            Description = "Blanditiis perspiciatis pariatur voluptas et voluptas consequatur nobis rem. Eos accusantium omnis molestias. Qui provident laboriosam molestiae ut. Non fuga quia magnam. Vitae quibusdam quaerat magnam eos at deserunt id. Aut non perspiciatis ut voluptatem est laborum nemo excepturi rerum.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg",
                            IsDeleted = false,
                            Latitude = -37.703499999999998,
                            Location = "865 Bartoletti Via, West Deannaland, Lebanon",
                            Longitude = -45.856999999999999,
                            Name = "Reillyside",
                            OpeningTime = new TimeSpan(0, 10, 0, 0, 0),
                            TicketPrice = 58.49m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(152),
                            Description = "Aperiam et veniam iure id et porro eligendi perspiciatis. Omnis dignissimos quasi. Necessitatibus praesentium dignissimos corporis quidem tempore. Blanditiis aut omnis modi dicta corrupti nihil enim adipisci. Veritatis asperiores mollitia architecto vitae et. Doloribus id provident ipsam.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/81.jpg",
                            IsDeleted = false,
                            Latitude = 67.864500000000007,
                            Location = "280 Christiansen Green, Clementinaburgh, South Africa",
                            Longitude = 19.017199999999999,
                            Name = "Mittieland",
                            OpeningTime = new TimeSpan(0, 9, 0, 0, 0),
                            TicketPrice = 76.11m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ClosingTime = new TimeSpan(0, 17, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(547),
                            Description = "Ullam tempora maxime esse tenetur. Ipsa blanditiis cum esse. Magni repudiandae fugiat id veniam. Fugit qui dolorem.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg",
                            IsDeleted = false,
                            Latitude = -48.9482,
                            Location = "9736 Sporer Springs, North Cheyennebury, Nepal",
                            Longitude = 178.39109999999999,
                            Name = "Adamston",
                            OpeningTime = new TimeSpan(0, 8, 0, 0, 0),
                            TicketPrice = 80.28m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(831),
                            Description = "Sunt alias quia nisi nemo cumque modi. Quia aut occaecati enim ipsum in aut et. Quisquam libero dignissimos. Iste aut in libero unde quis et. Quos error qui quia. Dicta qui sit facilis.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg",
                            IsDeleted = false,
                            Latitude = -63.603099999999998,
                            Location = "12238 Erdman Centers, Port Karelle, Congo",
                            Longitude = 173.72030000000001,
                            Name = "East Dorothyview",
                            OpeningTime = new TimeSpan(0, 9, 0, 0, 0),
                            TicketPrice = 7.18m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            ClosingTime = new TimeSpan(0, 18, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(1120),
                            Description = "Vitae asperiores impedit et reiciendis sit quas repudiandae nam. Et nisi sint laudantium. Et voluptas quasi nesciunt. Iste eos fuga dolorem. Aut necessitatibus suscipit.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1119.jpg",
                            IsDeleted = false,
                            Latitude = 89.689700000000002,
                            Location = "791 Nova Mountain, South Joe, Norway",
                            Longitude = -91.505200000000002,
                            Name = "Ahmedmouth",
                            OpeningTime = new TimeSpan(0, 8, 0, 0, 0),
                            TicketPrice = 68.08m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2015),
                            Description = "Expedita modi soluta commodi quo delectus reprehenderit. Dolorum aut voluptatum enim molestias nisi. Architecto fugit impedit accusamus quo rem. Occaecati et rerum sunt odit nobis saepe corporis aut possimus. Dolore voluptatem ut aliquam sit tempora eum unde. Rerum incidunt est.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/512.jpg",
                            IsDeleted = false,
                            Latitude = 65.177099999999996,
                            Location = "805 Roberto River, East Kristahaven, Dominican Republic",
                            Longitude = -30.507300000000001,
                            Name = "East Meredithtown",
                            OpeningTime = new TimeSpan(0, 9, 0, 0, 0),
                            TicketPrice = 45.30m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2319),
                            Description = "Sed possimus accusantium laudantium necessitatibus. Et quo repellat ut officia voluptatem laudantium doloremque. Voluptas harum non fuga quisquam.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg",
                            IsDeleted = false,
                            Latitude = 76.496399999999994,
                            Location = "352 Marco Village, Medhurstshire, Afghanistan",
                            Longitude = 81.767099999999999,
                            Name = "Dallastown",
                            OpeningTime = new TimeSpan(0, 10, 0, 0, 0),
                            TicketPrice = 21.91m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            ClosingTime = new TimeSpan(0, 19, 0, 0, 0),
                            CreatedDate = new DateTime(2024, 10, 11, 10, 1, 4, 345, DateTimeKind.Local).AddTicks(2570),
                            Description = "Voluptatum sit sunt fugiat maxime reprehenderit provident asperiores autem. Blanditiis libero occaecati et cupiditate officiis reprehenderit. Porro aut sed sit dignissimos nesciunt accusamus ut. Quae natus adipisci ut cupiditate omnis dolorum. Dolor dolorem blanditiis voluptate est cupiditate at.",
                            ImageUrl = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1082.jpg",
                            IsDeleted = false,
                            Latitude = 60.304699999999997,
                            Location = "4601 O'Conner Ford, Port Valeriechester, Bolivia",
                            Longitude = 12.238200000000001,
                            Name = "Tomasview",
                            OpeningTime = new TimeSpan(0, 8, 0, 0, 0),
                            TicketPrice = 92.75m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Destination", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Destinations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourGuide.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Destinations");
                });
#pragma warning restore 612, 618
        }
    }
}
