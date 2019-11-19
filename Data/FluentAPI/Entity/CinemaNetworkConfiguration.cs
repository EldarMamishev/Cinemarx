using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class CinemaNetworkConfiguration : EntityBaseConfiguration<CinemaNetworkEntity>
    {
        public override void Configure(EntityTypeBuilder<CinemaNetworkEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(cn => cn.Cinemas)
                .WithOne(c => c.CinemaNetwork)
                .HasForeignKey(c => c.CinemaNetworkId)
                .IsRequired(true);

            builder.HasIndex(cn => cn.WebSite)
                .IsUnique(true);
        }
    }
}
