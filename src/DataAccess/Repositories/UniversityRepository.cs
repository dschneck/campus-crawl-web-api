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

        public async Task<IEnumerable<University>> GetUniversitiesAsync()
        {
            var unis = await this.dbSet.ToListAsync();
            return unis;
        }

        public async Task<University> GetUniversityById(string id)
        {
            var uni =  this.dbSet.FromSqlRaw($"SELECT * FROM University WHERE Id='{id}'");
            return await uni.FirstOrDefaultAsync();
        }
    }
}
