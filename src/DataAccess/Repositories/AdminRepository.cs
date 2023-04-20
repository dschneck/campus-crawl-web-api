using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class AdminRepository
    {
        private readonly DbSet<Admin> dbSet;

        public AdminRepository(CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<Admin>();
        }

        public async Task<string> CreateRSO(Admin admin)
        {
            await this.dbSet.AddAsync(admin);
            return "ast";
        }
    }
}
