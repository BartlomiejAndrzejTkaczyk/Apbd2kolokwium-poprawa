using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class OrganizationConf : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder
                .HasKey(x => x.OrganizationID);

            builder
                .Property(x => x.OrganizationName)
                .HasMaxLength(100);

            builder
                .Property(x => x.OrganizationDomain)
                .HasMaxLength(50);

            builder
                .HasMany(x => x.Teams)
                .WithOne(x => x.TheOrganization);
        }
    }
}
