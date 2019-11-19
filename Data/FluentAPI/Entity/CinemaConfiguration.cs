using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class CinemaConfiguration : EntityBaseConfiguration<CinemaEntity>
    {
        public override void Configure(EntityTypeBuilder<CinemaEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(c => c.FilmInCinemas)
                .WithOne(fc => fc.Cinema)
                .HasForeignKey(fc => fc.CinemaId)
                .IsRequired(true);

            builder.HasOne(c => c.CinemaNetwork)
                .WithMany(cn => cn.Cinemas)
                .HasForeignKey(c => c.CinemaNetworkId)
                .IsRequired(true);

            builder.HasMany(c => c.Halls)
                .WithOne(h => h.Cinema)
                .HasForeignKey(h => h.CinemaId)
                .IsRequired(true);

            builder.Property(p => p.Address)
                .IsRequired(true);

            builder.Property(p => p.Caption)
                .IsRequired(true);

            builder.Property(p => p.City)
                .IsRequired(true);

            builder.Property(p => p.Description)
                .IsRequired(false);

            builder.Property(p => p.Email)
                .IsRequired(false);

            builder.Property(p => p.PhoneNumber)
                .IsRequired(false);
        }
    }
}
