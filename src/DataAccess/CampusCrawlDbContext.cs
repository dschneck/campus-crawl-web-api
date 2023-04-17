using Microsoft.EntityFrameworkCore;
using System.Reflection;
using DataAccess.Entities;

namespace DataAccess
{
    public class CampusCrawlDbContext : DbContext {
        public CampusCrawlDbContext(DbContextOptions options)
        {
        }

        public DbSet<University> University { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
