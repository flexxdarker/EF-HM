using HM16._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM16._08._2023.Data
{
    public class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicApp;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Countries>().HasData(new[]
            {
                new Countries() {Id = 1, Name = "Ukraine"},
                new Countries() {Id = 2, Name = "Poland"},
                new Countries() {Id = 3, Name = "UK"}
            });
            modelBuilder.Entity<Ganres>().HasData(new[]
            {
                new Ganres() {Id = 1, Name = "Pop"},
                new Ganres() {Id = 2, Name = "Rock"},
                new Ganres() {Id = 3, Name = "Metalic"},
                new Ganres() {Id = 4, Name = "Phonk"}
            }) ;
            modelBuilder.Entity<Categories>().HasData(new[]
            {
                new Categories() {Id = 1, Name = "For Sitmul"},
                new Categories() {Id = 2, Name = "Chill Out"}
            });
            modelBuilder.Entity<Artists>().HasData(new[]
            {
                new Artists() {Id = 1, Name = "Kyzma",Surname = "Skriabin", CountriesId = 1 },
                new Artists() {Id = 2, Name = "Mishai",Surname = "Sensei", CountriesId = 2},
                new Artists() {Id = 3, Name  = "Lucky", Surname = "Luke", CountriesId = 3}
            });
            modelBuilder.Entity<Albums>().HasData(new[]
            {
                new Albums() {Id = 1, Name = "Kolomuyki", ArtistsId = 1, GanreId = 2, Year = 2014},
                new Albums() {Id = 2, Name = "Sending Money", ArtistsId = 2, GanreId = 4, Year = 2020},
                new Albums() {Id = 3, Name = "Wonderwall", ArtistsId = 3, GanreId  = 1, Year = 2018}
            });
            modelBuilder.Entity<Tracks>().HasData(new[]
            {
                new Tracks() {Id = 1, Name = "Kolomuyki - Skryabina", AlbumsId = 1, Duration = 240},
                new Tracks() {Id = 2, Name = "Sending Money", AlbumsId = 2, Duration = 260},
                new Tracks() {Id = 3, Name = "WonderWall", AlbumsId = 3, Duration = 250}
            });
            modelBuilder.Entity<Playlists>().HasData(new[]
            {
                new Playlists() {Id = 1, Name = "Chilling out", CategoryId = 2}
            });
        }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Playlists> Playlists { get; set; }
        public DbSet<Tracks> Tracks { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Ganres> Ganres { get; set; }
    }
}
