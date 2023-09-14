﻿// <auto-generated />
using System;
using DbToHM21._08._2023.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbToHM21._08._2023.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230914154225_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Products"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Military Equipment"
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Rivne"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Krakiw"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Chicago"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 4,
                            Name = "London"
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 3,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "UK"
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Seller"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Operator"
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Discount = 20f,
                            IsInStock = true,
                            Name = "Shoes",
                            Price = 200m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Discount = 0f,
                            IsInStock = true,
                            Name = "Guitar",
                            Price = 250m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Discount = 1f,
                            IsInStock = false,
                            Name = "Fruits",
                            Price = 10m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Discount = 200f,
                            IsInStock = true,
                            Name = "Gun",
                            Price = 5000m,
                            Quantity = 20
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkingArea")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Shop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Soborna 28",
                            CityId = 1,
                            Name = "ClothingForEveryOne",
                            ParkingArea = 20
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Krakowska st.",
                            CityId = 2,
                            Name = "MusicShop",
                            ParkingArea = 5
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Route 69",
                            CityId = 3,
                            Name = "Walmart",
                            ParkingArea = 100
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("ShopId");

                    b.ToTable("Worker");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Aleksandr@gmail.com",
                            Name = "Alexandr",
                            PhoneNumber = "13246579",
                            PositionId = 1,
                            Salary = 2200m,
                            ShopId = 1,
                            Surname = "Sandr"
                        },
                        new
                        {
                            Id = 2,
                            Email = "PolskiyVitya@gmail.com",
                            Name = "Viktor",
                            PhoneNumber = "547921364",
                            PositionId = 2,
                            Salary = 2199m,
                            ShopId = 2,
                            Surname = "Polskiy"
                        },
                        new
                        {
                            Id = 3,
                            Email = "LonskaSonya@gmai.com",
                            Name = "Sonya",
                            PhoneNumber = "15971369774",
                            PositionId = 2,
                            Salary = 12000m,
                            ShopId = 3,
                            Surname = "Lonska"
                        });
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.City", b =>
                {
                    b.HasOne("DbToHM21._08._2023.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Product", b =>
                {
                    b.HasOne("DbToHM21._08._2023.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Shop", b =>
                {
                    b.HasOne("DbToHM21._08._2023.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DbToHM21._08._2023.Entities.Worker", b =>
                {
                    b.HasOne("DbToHM21._08._2023.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbToHM21._08._2023.Entities.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Shop");
                });
#pragma warning restore 612, 618
        }
    }
}
