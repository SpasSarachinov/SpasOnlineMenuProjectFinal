﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpasOnlineMenuProjectFinal.Data;

#nullable disable

namespace SpasOnlineMenuProjectFinal.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240522105124_IsDeletedAdded")]
    partial class IsDeletedAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HouseRentingSystem.Data.Entities.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://assets-eu-01.kc-usercontent.com/00b9925d-7322-014e-f702-6ef9aa1a28b4/f509cc3f-85ee-4f27-bd60-1384807311b5/01072018-293.jpg?w=1200&fm=webp&lossless=0&q=80",
                            Ingredients = "яйца,питка, тънки резени бекон, магданоз,лимонов сок",
                            IsDeleted = false,
                            Price = 18m,
                            Title = "Яйца Бенедеикт"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://media-cldnry.s-nbcnews.com/image/upload/t_social_share_1200x630_center,f_auto,q_auto:best/newscms/2020_04/1530595/fluffy-scrambled-eggs-today-main-200121-2.jpg",
                            Ingredients = "яйца, черен пипер, сметана",
                            IsDeleted = false,
                            Price = 8.90m,
                            Title = "Бъркани яйца"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/215620/fit_640_400.png?rev=1697484896",
                            Ingredients = "Телешки стек с чимичури сос, чушки пимиентос де падрон и пюре от сладък картоф",
                            IsDeleted = false,
                            Price = 25.20m,
                            Title = "Телешки стек"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/27142/fit_640_400.png?rev=1643806171",
                            Ingredients = "Свински ребра с азиатски барбекю сос, кашу и зелен лук.",
                            IsDeleted = false,
                            Price = 30.50m,
                            Title = "Ребра Иберико По Азиатски"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/228302/fit_640_400.png?rev=1697363605",
                            Ingredients = "Свински котлет в специална марината, печени картофи, чимичури и пимиентос де падрон.",
                            IsDeleted = false,
                            Price = 30.99m,
                            Title = "Аржентински котлет"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/6981/fit_640_400.png?rev=1637069133",
                            Ingredients = "Хосомаки краставица 16 бр., Филаделфия сьомга, авокадо и хрупкава темпура 8 бр., Норвежка гора 8 бр.,  Филаделфия пушена сьомга 8 бр., Филаделфия хрупкаво пиле 8 бр.",
                            IsDeleted = false,
                            Price = 50.50m,
                            Title = "Екстра Суши Комбо 48 БР"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/120941/fit_640_400.png?rev=1675441077",
                            Ingredients = "Чикън Везувий 8 бр., Чикън Кинг 6 бр., Клуб Чикън 4 бр., Дракон пиле 4 бр., Трюфел пиле 8 бр.",
                            IsDeleted = false,
                            Price = 30.99m,
                            Title = "Макси Чикън 30 БР"
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/116440/fit_640_400.png?rev=1674131382",
                            Ingredients = "Футомаки хрупкаво пиле с Филаделфия и амарант 6 бр., Филаделфия сьомга, авокадо и хрупкава темпура 4 бр., Емирейтс рол с манго и Филаделфия 4 бр., Хепи майонеза, унаги сос и ядлива златна пудра.",
                            IsDeleted = false,
                            Price = 20.50m,
                            Title = "Бурж Ал Араб 14 БР"
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/3882/fit_640_400.png?rev=1626000157",
                            Ingredients = "Суфле с течен център от шоколад.",
                            IsDeleted = false,
                            Price = 7.90m,
                            Title = "Суфле С Течен Център Шоколад"
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "https://dostavka.happy.bg/remote/files/images/353328/fit_640_400.png?rev=1707735140",
                            Ingredients = "Хрупкав бисквитен блат, маскарпоне крем, сладко от ягоди и шоколад.",
                            IsDeleted = false,
                            Price = 8.00m,
                            Title = "Нутела С Ягоди И Маскарпоне"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
