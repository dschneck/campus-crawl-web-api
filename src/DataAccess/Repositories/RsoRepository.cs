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

        public async Task<bool> LeaveRso(string userId, string rsoId)
        {
            var entity = this.memberdbSet.Where(x => x.UserId == userId && x.RSOId == rsoId).First();
            this.memberdbSet.Remove(entity);
            return true;
        }

        public async Task<bool> JoinRso(string userId, string rsoId)
        {
            await this.memberdbSet.AddAsync(new Member() {
                UserId = userId,
                RSOId = rsoId,
                Id = Guid.NewGuid().ToString(),
                User = new User(){},
                RSO = new RSO(){}
            });

            return true;
        }}
}
