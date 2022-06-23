using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class MemberConf : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                .HasKey(x => x.MemberID);

            builder
                .Property(x => x.MemberName)
                .HasMaxLength(20);

            builder
                .Property(x => x.MemberSurname)
                .HasMaxLength(50);

            builder
                .Property(x => x.MemberNickName)
                .IsRequired(false)
                .HasMaxLength(20);

            builder
                .HasMany(x => x.Memberships)
                .WithOne(x => x.TheMember);

            builder
                .HasOne(x => x.TheOrganization)
                .WithMany(x => x.Members);
        }
    }
}
