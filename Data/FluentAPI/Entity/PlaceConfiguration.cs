using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class PlaceConfiguration : EntityBaseConfiguration<PlaceEntity>
    {
        public override void Configure(EntityTypeBuilder<PlaceEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Hall)
                .WithMany(h => h.Places)
                .HasForeignKey(p => p.HallId)
                .IsRequired(true);

            builder.HasMany(p => p.Tickets)
                .WithOne(t => t.Place)
                .HasForeignKey(t => t.PlaceId)
                .IsRequired(true);

            builder.Property(p => p.PlaceLine)
                .IsRequired(true);

            builder.Property(p => p.PlaceNumber)
                .IsRequired(true);

            builder.Property(p => p.Class)
                .IsRequired(true);
        }
    }
}
