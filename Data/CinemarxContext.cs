using Data.FluentAPI;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class CinemarxContext : DbContext
    {
        public CinemarxContext(DbContextOptions options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CinemarxDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonEntity>().HasData(this.Initialize());

            new ModelConfigurationHandler().SetConfigurations(modelBuilder);
        }

        private PersonEntity[] Initialize()
        {
            return new[] { 
                new PersonEntity() { Id = 1, Name = "Bob", Surname = "Smith", Email = "smithbob@gmail.com", 
                    Password = "00000", BirthDate = DateTime.Now.AddYears(-20), RegistrationDate = DateTime.Now }};
        }

        public DbSet<CinemaEntity> Families { get; set; }
        public DbSet<CinemaNetworkEntity> Operations { get; set; }
        public DbSet<FilmEntity> OperationCategories { get; set; }
        public DbSet<FilmInCinemaEntity> OperationInfos { get; set; }
        public DbSet<PersonEntity> People { get; set; }
        public DbSet<TicketEntity> PersonFamilies { get; set; }
        public DbSet<SessionEntity> PersonWallets { get; set; }
        public DbSet<HallEntity> Transactions { get; set; }
        public DbSet<PlaceEntity> Wallets { get; set; }
    }
}
