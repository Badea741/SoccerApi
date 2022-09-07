using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Soccer.Shared.Entities.Configurations;
public class PlayerConfiguration : BaseConfiguration<Player>
{
    public override void Configure(EntityTypeBuilder<Player> builder=null!)
    {
        builder.ToTable("players");
        base.Configure(builder);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Nationality).IsRequired().HasMaxLength(20);
        builder.Property(p => p.DateOfBirth).IsRequired();
        builder.HasMany(p => p.Teams).WithMany(t => t.Players);
    }
}