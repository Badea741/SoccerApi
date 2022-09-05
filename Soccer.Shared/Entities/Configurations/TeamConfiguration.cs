namespace Soccer.Shared.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Soccer.Shared.Entities;
    public class TeamConfiguration : BaseConfiguration<Team>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
            base.Configure(builder);
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Country).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Founded).IsRequired();
            builder.Property(t => t.CoachName).IsRequired();
            builder.HasMany(t => t.Players).WithMany(p => p.Teams);
        }
    }
}