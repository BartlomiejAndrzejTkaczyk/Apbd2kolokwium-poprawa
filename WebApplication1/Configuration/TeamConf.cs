using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class TeamConf : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(x => x.TeamID);

            builder
                .Property(x => x.TeamName)
                .HasMaxLength(50);

            builder
                .Property(x => x.TeamDescription)
                .IsRequired(false)
                .HasMaxLength(500);

            builder
                .HasMany(x => x.Files)
                .WithOne(x => x.TheTeam);
        }
    }
}
