using Microsoft.EntityFrameworkCore;
using System.Reflection;
using DataAccess.Entities;
using Microsoft.Extensions.Logging;

namespace DataAccess
{
    public class CampusCrawlDbContext : DbContext {
        private readonly ILoggerFactory logger;

        public CampusCrawlDbContext(DbContextOptions options, ILoggerFactory logger): base(options)
        {
            this.logger = logger;
        }

        public DbSet<University> University { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(this.logger);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
