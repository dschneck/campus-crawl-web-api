using DataAccess.Entities;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class MemberRepository
    {
        private readonly DbSet<Member> dbSet;

        public MemberRepository(CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<Member>();
        }

        public async Task<bool> JoinRso(Member member)
        {
            await this.dbSet.AddAsync(member);

            return true;
        }

        public async Task<bool> LeaveRso(string userId, string rsoId)
        {
            var entity = this.dbSet.Where(x => x.UserId == userId && x.RSOId == rsoId).First();
            this.dbSet.Remove(entity);
            return true;
        }

        public async Task<IEnumerable<Member>>GetAllByUserId(string userId)
        {
            var members = await this.dbSet.Where(x => x.UserId == userId).ToListAsync();
            return members;
        }
    }
}
