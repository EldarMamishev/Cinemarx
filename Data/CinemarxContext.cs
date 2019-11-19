using Data.FluentAPI;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CinemarxContext : DbContext
    {
        public CinemarxContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ModelConfigurationHandler().SetConfigurations(modelBuilder);
        }

        private void Initialize()
        {
            var person = new PersonEntity() { Name = "Bob", Surname = "Smith", Email = "smithbob@gmail.com", Password = "00000" };
            this.People.Add(person);
            
            this.SaveChanges();
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
