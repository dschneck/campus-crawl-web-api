using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class RsoRepository
    {
        private readonly DbSet<RSO> dbSet;

        public RsoRepository(CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<RSO>();
        }

        public async Task<RSO> CreateRSO(RSO rso)
        {
            rso.Id = Guid.NewGuid().ToString();

            await this.dbSet.AddAsync(rso);
            return await this.dbSet.FindAsync(rso.Id);
        }
    }
}
