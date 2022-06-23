using Microsoft.EntityFrameworkCore;
using WebApplication1.Extensions;
using WebApplication1.Models;
namespace WebApplication1.DbAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<FileModel> Files { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            
        }
    }
}
