using Data.FluentAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.FluentAPI
{
    public sealed class ModelConfigurationHandler
    {
        public void SetConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CinemaConfiguration());
            modelBuilder.ApplyConfiguration(new CinemaNetworkConfiguration());
            modelBuilder.ApplyConfiguration(new HallConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new SessionConfiguration());
            modelBuilder.ApplyConfiguration(new FilmInCinemaConfiguration());
            modelBuilder.ApplyConfiguration(new FilmConfiguration());
        }
    }
}
