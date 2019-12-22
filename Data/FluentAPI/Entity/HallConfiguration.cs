using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class HallConfiguration : EntityBaseConfiguration<HallEntity>
    {
        public override void Configure(EntityTypeBuilder<HallEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(h => h.Cinema)
                .WithMany(c => c.Halls)
                .HasForeignKey(h => h.CinemaId)
                .IsRequired(true);

            builder.HasMany(h => h.Places)
                .WithOne(p => p.Hall)
                .HasForeignKey(p => p.HallId)
                .IsRequired(true);

            builder.HasMany(h => h.Sessions)
                .WithOne(p => p.Hall)
                .HasForeignKey(p => p.HallId)
                .IsRequired(true);

            builder.Property(p => p.Caption)
                .IsRequired(true);

            builder.Property(p => p.ScreenType)
                .IsRequired(true);
        }
    }
}
