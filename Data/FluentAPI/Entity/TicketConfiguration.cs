using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class TicketConfiguration : EntityBaseConfiguration<TicketEntity>
    {
        public override void Configure(EntityTypeBuilder<TicketEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(t => t.Person)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PersonId)
                .IsRequired(true);

            builder.HasOne(t => t.Place)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PlaceId)
                .IsRequired(true);

            builder.HasOne(t => t.Session)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.SessionId)
                .IsRequired(true);

            builder.Property(p => p.Price)
                .IsRequired(true);

            builder.Property(p => p.PurchasedDate)
                .IsRequired(true);

            builder.Property(p => p.RevertedDate)
                .IsRequired(false);

            builder.Property(p => p.IsActive)
                .IsRequired(true);
        }
    }
}
