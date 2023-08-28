using DbTo18._08._2023.Entities;
using Hm18._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Data
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext() : base()
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Airport;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sexs>().HasData(new[]
            {
                new Sexs() { Id = 1, Sex = "Male" },
                new Sexs() { Id = 2, Sex = "Female"}
            });
            modelBuilder.Entity<Accounts>().HasData(new[]
            {
                new Accounts() { Id = 1, Login = "firstTime", Password = "myfirsttime"},
                new Accounts() { Id = 2, Login = "favAirline", Password = "rasha-parasha"}
            });
            modelBuilder.Entity<Airplanes>().HasData(new[]
            {
                new Airplanes() { Id = 1, Country = "Ukraine", Type = "Jet", Model = "CJ2", MaxPassengers = 8},
                new Airplanes() { Id = 2, Country = "Poland", Type = "Airbus", Model = "A380", MaxPassengers = 545},
            });
            modelBuilder.Entity<Clients>().HasData(new[]
            {
                new Clients() { Id = 1, Name = "Andrii", Surname = "Polishuck", SexsId = 1, Email ="AdrPolichuck@gmail.com", AccountsId = 1, FlightsId = 1},
                new Clients() { Id = 2, Name = "Oleksandr", Surname = "Pulupenko", SexsId = 1, Email = "pulupenkoOleks@gmail.com", AccountsId = 2, FlightsId = 2}
            });
            modelBuilder.Entity<Flights>().HasData(new[]
            {
                new Flights() { Id = 1, Number = 1, AirplanesId = 1, DispatchDate = new DateOnly(2018,02,20), ArrivalDate = new DateOnly(2018,02,21), DispatchPlace = "San Diego", ArrivalPlace = "London", },
                new Flights() { Id = 2, Number = 2, AirplanesId = 2, DispatchDate = new DateOnly(2020, 10, 12), ArrivalDate = new DateOnly(2020,10,13), DispatchPlace = "Los Angeles", ArrivalPlace = "Berlin"}
            });
        }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Sexs> Sexs { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Airplanes> Airplanes { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
    }
}
