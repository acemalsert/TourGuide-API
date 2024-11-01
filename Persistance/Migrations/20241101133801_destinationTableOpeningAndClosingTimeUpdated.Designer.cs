﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourGuide.Persistance.Context;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241101133801_destinationTableOpeningAndClosingTimeUpdated")]
    partial class destinationTableOpeningAndClosingTimeUpdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CategoryName = "Computers",
                            CreatedDate = new DateTime(2024, 2, 21, 4, 22, 31, 536, DateTimeKind.Local).AddTicks(3524),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Sports",
                            CreatedDate = new DateTime(2023, 1, 8, 9, 7, 59, 119, DateTimeKind.Local).AddTicks(15),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Music",
                            CreatedDate = new DateTime(2024, 1, 10, 19, 9, 49, 9, DateTimeKind.Local).AddTicks(9397),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Garden",
                            CreatedDate = new DateTime(2022, 11, 23, 20, 19, 14, 1, DateTimeKind.Local).AddTicks(3187),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Games",
                            CreatedDate = new DateTime(2023, 7, 28, 7, 16, 48, 94, DateTimeKind.Local).AddTicks(6254),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Domain.Entities.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClosingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 6, 35, 918, DateTimeKind.Local).AddTicks(5835),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(3218),
                            Description = "Veniam quod quisquam mollitia magni tenetur occaecati tenetur. Sapiente qui quos ipsam qui soluta numquam eos voluptatem qui. Necessitatibus et voluptas aut animi consequatur at vel cum repudiandae. Ut rerum quae quia quis. Fugit commodi assumenda accusantium omnis unde itaque ut.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/342.jpg",
                            IsDeleted = false,
                            Name = "Harveyport",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 1, 21, 114, DateTimeKind.Local).AddTicks(7856),
                            TicketPrice = 49.98m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 33, 51, 449, DateTimeKind.Local).AddTicks(7036),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(4811),
                            Description = "Officia et animi aspernatur fugit. Nisi non magnam. Sit et error inventore. Sed unde aut maxime odio facere quaerat. Consequuntur aut et ea veritatis aperiam earum cumque sint facilis. Alias doloremque expedita.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/773.jpg",
                            IsDeleted = false,
                            Name = "Anastaciofort",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 18, 12, 857, DateTimeKind.Local).AddTicks(6969),
                            TicketPrice = 44.49m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 13, 6, 655, DateTimeKind.Local).AddTicks(6190),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5085),
                            Description = "Delectus quia sequi reprehenderit sint. Perferendis et minus nobis ipsum aperiam voluptatem quidem architecto ut. Consectetur in voluptatem itaque eveniet. Et suscipit eligendi earum. Dolorum corrupti quo sapiente recusandae a vitae. Et enim voluptatibus iure aut neque qui cum ut suscipit.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/754.jpg",
                            IsDeleted = false,
                            Name = "Penelopetown",
                            OpeningTime = new DateTime(2024, 11, 1, 8, 25, 32, 767, DateTimeKind.Local).AddTicks(1054),
                            TicketPrice = 24.65m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            ClosingTime = new DateTime(2024, 11, 1, 17, 7, 53, 38, DateTimeKind.Local).AddTicks(6529),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5269),
                            Description = "Adipisci maiores cum magni accusamus sit quae sed sunt. Dignissimos distinctio corrupti architecto et blanditiis fugiat beatae qui eos. Expedita quo cumque a autem. Nihil sequi eum mollitia quo et ut adipisci et. Quo neque suscipit incidunt assumenda esse vel molestiae molestias. Voluptatibus porro modi modi.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/860.jpg",
                            IsDeleted = false,
                            Name = "Charitystad",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 34, 51, 691, DateTimeKind.Local).AddTicks(1834),
                            TicketPrice = 24.83m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 19, 4, 511, DateTimeKind.Local).AddTicks(1211),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5436),
                            Description = "Qui vero quibusdam reprehenderit fugit et. Est perspiciatis corporis corrupti qui. Sit dolorem commodi deleniti ducimus voluptas quia est laudantium. Optio nemo incidunt consectetur voluptatem.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/681.jpg",
                            IsDeleted = false,
                            Name = "Raeside",
                            OpeningTime = new DateTime(2024, 11, 1, 8, 51, 56, 459, DateTimeKind.Local).AddTicks(765),
                            TicketPrice = 24.39m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ClosingTime = new DateTime(2024, 11, 1, 17, 31, 16, 865, DateTimeKind.Local).AddTicks(8987),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5554),
                            Description = "Aliquam minus officiis in nulla dolor magni culpa molestiae. Totam dolor repellendus voluptatem. Nesciunt exercitationem quaerat eius assumenda eveniet quia molestiae.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg",
                            IsDeleted = false,
                            Name = "Port Haleighmouth",
                            OpeningTime = new DateTime(2024, 11, 1, 8, 1, 33, 204, DateTimeKind.Local).AddTicks(8019),
                            TicketPrice = 72.53m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 51, 48, 420, DateTimeKind.Local).AddTicks(3047),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5729),
                            Description = "Et tenetur accusamus exercitationem mollitia debitis vitae ut nobis ut. Aut suscipit quae sint commodi deserunt et dolorem qui quo. Autem velit aut. Quae reiciendis porro sit ad corporis. Ipsam eum eveniet aliquid qui in.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1090.jpg",
                            IsDeleted = false,
                            Name = "North Glen",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 7, 34, 688, DateTimeKind.Local).AddTicks(6344),
                            TicketPrice = 27.19m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 30, 13, 238, DateTimeKind.Local).AddTicks(5756),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(5887),
                            Description = "Facilis esse dolore quod voluptatibus. Natus est fugiat minima dignissimos quas cumque et excepturi sunt. Est autem totam hic repellendus expedita deleniti qui. Et ex aut vitae temporibus sed. Et quia vel expedita earum dolore facilis est. Voluptatum nam saepe officia doloribus sunt.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1078.jpg",
                            IsDeleted = false,
                            Name = "Terryland",
                            OpeningTime = new DateTime(2024, 11, 1, 8, 22, 34, 611, DateTimeKind.Local).AddTicks(3664),
                            TicketPrice = 71.32m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 38, 13, 624, DateTimeKind.Local).AddTicks(5560),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6074),
                            Description = "Pariatur perferendis assumenda error dolore quia. Consectetur id deleniti ab rerum non aperiam. Id dolorem qui a et omnis enim nihil. Sunt et quia ipsa est animi architecto reprehenderit quia iste. Ipsa molestiae deserunt aut corporis magni fugiat et tenetur explicabo.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1093.jpg",
                            IsDeleted = false,
                            Name = "Connerchester",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 53, 11, 632, DateTimeKind.Local).AddTicks(8939),
                            TicketPrice = 15.58m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            ClosingTime = new DateTime(2024, 11, 1, 18, 8, 35, 595, DateTimeKind.Local).AddTicks(7600),
                            CreatedDate = new DateTime(2024, 11, 1, 16, 38, 1, 142, DateTimeKind.Local).AddTicks(6215),
                            Description = "Eveniet quia laboriosam accusantium. Voluptate quam nesciunt earum modi magni autem. Tempora ea maiores impedit. Nisi sapiente deserunt. Eveniet repudiandae voluptatum recusandae. Nemo iusto explicabo.",
                            ImageData = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg",
                            IsDeleted = false,
                            Name = "South Horaceborough",
                            OpeningTime = new DateTime(2024, 11, 1, 9, 52, 31, 811, DateTimeKind.Local).AddTicks(7456),
                            TicketPrice = 82.71m
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

            modelBuilder.Entity("TourGuide.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.DestinationAddress", b =>
                {
                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("DestinationId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("DestinationAddresses");
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
                    b.HasOne("TourGuide.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Destinations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

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

            modelBuilder.Entity("TourGuide.Domain.Entities.Address", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.DestinationAddress", b =>
                {
                    b.HasOne("TourGuide.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("TourGuide.Domain.Entities.Country", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
