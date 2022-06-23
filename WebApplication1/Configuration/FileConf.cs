using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class FileConf : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<Models.File> builder)
        {
            throw new NotImplementedException();
        }
    }
}
