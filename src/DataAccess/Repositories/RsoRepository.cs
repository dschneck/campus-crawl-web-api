using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class RsoRepository
    {
        private readonly DbSet<RSO> dbSet;
        private readonly DbSet<Member> memberdbSet;

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

        public async Task<IEnumerable<RSO>> GetRsosFromUniversityId(string universityId)
        {
            var rsos  = await this.dbSet.Where(x => x.UniversityId == universityId).ToListAsync();
            return rsos;
        }

        public async Task<RSO> GetRsoById(string rsoId)
        {
            var user = await this.dbSet.FirstOrDefaultAsync(x => x.Id.Equals(rsoId));
            return user;
        }
    }


}
