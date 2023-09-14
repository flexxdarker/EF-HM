using DbToHM21._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbToHM21._08._2023.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
            optionsBuilder.UseLazyLoadingProxies(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new[]
            { 
                new Country() {Id = 1, Name = "Ukraine"},
                new Country() {Id = 2, Name = "Poland"},
                new Country() {Id = 3, Name = "USA"},
                new Country() {Id = 4, Name = "UK"}
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = 1, Name = "Clothing"},
                new Category() {Id = 2, Name = "Musical Instruments"},
                new Category() {Id = 3, Name = "Products"},
                new Category() {Id = 4, Name = "Military Equipment"}
            });
            modelBuilder.Entity<Position>().HasData(new[]
            {
                new Position() {Id = 1, Name = "Admin"},
                new Position() {Id = 2, Name = "Seller"},
                new Position() {Id = 3, Name = "Operator"}
            });
            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() {Id = 1, Name = "Rivne", CountryId = 1},
                new City() {Id = 2, Name = "Krakiw", CountryId = 2},
                new City() {Id = 3, Name = "Chicago", CountryId = 3},
                new City() {Id = 4, Name = "London", CountryId = 4},
            });
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() {Id = 1, Name = "Shoes", CategoryId = 1, Price = 200, Quantity = 20, Discount = 20, IsInStock = true },
                new Product() {Id = 2, Name = "Guitar", CategoryId = 2, Price = 250, Discount = 0, Quantity = 5, IsInStock = true },
                new Product() {Id = 3, Name = "Fruits", CategoryId = 3, Price = 10, Discount = 1, Quantity = 0, IsInStock = false},
                new Product() {Id = 4, Name = "Gun", CategoryId = 4, Price = 5000, Quantity = 20, IsInStock = true, Discount = 200}
            });
            modelBuilder.Entity<Shop>().HasData(new[]
            {
                new Shop() {Id = 1, CityId = 1, Adress = "Soborna 28", Name = "ClothingForEveryOne", ParkingArea = 20},
                new Shop() {Id = 2, CityId = 2, Name = "MusicShop", Adress = "Krakowska st.", ParkingArea = 5},
                new Shop() {Id = 3, CityId = 3, Name = "Walmart", Adress = "Route 69", ParkingArea = 100},
            });
            modelBuilder.Entity<Worker>().HasData(new[]
            {
                new Worker() {Id = 1, Name = "Alexandr", Surname = "Sandr", ShopId = 1, Salary = 2200, Email = "Aleksandr@gmail.com", PositionId = 1, PhoneNumber = "13246579"},
                new Worker() {Id = 2, Name = "Viktor", Surname = "Polskiy", ShopId = 2, PositionId = 2, Email = "PolskiyVitya@gmail.com", Salary = 2199, PhoneNumber = "547921364"},
                new Worker() {Id = 3, Name = "Sonya", Surname = "Lonska", ShopId = 3, Email = "LonskaSonya@gmai.com", PhoneNumber = "15971369774", Salary = 12000, PositionId = 2}
            });
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
