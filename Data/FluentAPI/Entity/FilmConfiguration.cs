using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class FilmConfiguration : EntityBaseConfiguration<FilmEntity>
    {
        public override void Configure(EntityTypeBuilder<FilmEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(f => f.FilmInCinemas)
                .WithOne(fc => fc.Film)
                .HasForeignKey(f => f.FilmId)
                .IsRequired(true);

            builder.Property(p => p.Caption)
                .IsRequired(true);

            builder.Property(p => p.Duration)
                .IsRequired(true);

            builder.Property(p => p.PremiereDate)
                .IsRequired(false);
        }
    }
}
