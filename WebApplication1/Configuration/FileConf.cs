using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class FileConf : IEntityTypeConfiguration<FileModel>
    {
        public void Configure(EntityTypeBuilder<FileModel> builder)
        {
            builder
                .HasKey(x => new { x.FileID, x.TeamID });

            builder
                .Property(x => x.FileName)
                .HasMaxLength(100);

            builder
                .Property(x => x.FileExtension)
                .HasMaxLength(4);
        }
    }
}
