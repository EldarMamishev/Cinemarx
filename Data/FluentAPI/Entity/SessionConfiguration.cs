using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class SessionConfiguration : EntityBaseConfiguration<SessionEntity>
    {
        public override void Configure(EntityTypeBuilder<SessionEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(s => s.Tickets)
                .WithOne(t => t.Session)
                .HasForeignKey(t => t.SessionId)
                .IsRequired(true);

            builder.HasOne(s => s.Hall)
                .WithMany(h => h.Sessions)
                .HasForeignKey(t => t.HallId)
                .IsRequired(true);

            builder.HasOne(s => s.FilmInCinema)
                .WithMany(fc => fc.Sessions)
                .HasForeignKey(s => s.FilmInCinemaId)
                .IsRequired(true);

            builder.Property(p => p.BaseTicketPrice)
                .IsRequired(true);

            builder.Property(p => p.DateAndTime)
                .IsRequired(true);
        }
    }
}
