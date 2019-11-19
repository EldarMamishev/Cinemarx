using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class FilmInCinemaConfiguration : EntityBaseConfiguration<FilmInCinemaEntity>
    {
        public override void Configure(EntityTypeBuilder<FilmInCinemaEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(fc => fc.Cinema)
                .WithMany(c => c.FilmInCinemas)
                .HasForeignKey(fc => fc.CinemaId)
                .IsRequired(true);

            builder.HasOne(fc => fc.Film)
                .WithMany(f => f.FilmInCinemas)
                .HasForeignKey(fc => fc.FilmId)
                .IsRequired(true);

            builder.HasMany(fc => fc.Sessions)
                .WithOne(s => s.FilmInCinema)
                .HasForeignKey(t => t.FilmInCinemaId)
                .IsRequired(true);

            builder.Property(p => p.DateOfStart)
                .IsRequired(true);

            builder.Property(p => p.DateOfEnd)
                .IsRequired(true);
        }
    }
}
