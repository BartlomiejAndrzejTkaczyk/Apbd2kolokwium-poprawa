using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class MebershipConf : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder
                .HasKey(x => new { x.MemberID, x.TeamID });

            builder
                .HasOne(x => x.TheMember)
                .WithMany(x => x.Memberships)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.TheTeam)
                .WithMany(x => x.Memberships)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
