using Data.FluentAPI.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentAPI.Entity
{
    public class PersonConfiguration : EntityBaseConfiguration<PersonEntity>
    {
        public override void Configure(EntityTypeBuilder<PersonEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(p => p.Tickets)
                .WithOne(t => t.Person)
                .HasForeignKey(t => t.PersonId)
                .IsRequired(true);

            builder.Property(p => p.Name)
                .IsRequired(true);

            builder.Property(p => p.Surname)
                .IsRequired(true);

            builder.HasIndex(p => p.Email)
                .IsUnique(true);

            builder.Property(p => p.BirthDate)
                .IsRequired(true);

            builder.Property(p => p.Password)
                .IsRequired(true);

            builder.Property(p => p.RegistrationDate)
                .IsRequired(true);
        }
    }
}
