using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Soccer.Shared.Entities.Configurations;
public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.CreationDate).HasDefaultValue(DateTime.Now);
        builder.Property(e => e.ConcurrencyStamp).IsRowVersion();
    }
}