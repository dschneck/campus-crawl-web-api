using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class UniversityRepository
    {
        private readonly DbSet<University> dbSet;

        public UniversityRepository(CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<University>();
        }

        public async Task<string> CreateUniversity(University university)
        {
            await this.dbSet.AddAsync(university);
            return university.Id;
        }
    }
}
