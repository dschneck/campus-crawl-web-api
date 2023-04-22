using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class RsoEventRepository
    {
        private readonly DbSet<RsoEvent> dbSet;

        public RsoEventRepository (CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<RsoEvent>();
        }
        public async Task<IEnumerable<Event>> GetEventsByRsoId(string rsoId)
        {
            var rsoEvents = await this.dbSet.Where(x => x.RsoId.Equals(rsoId)).ToListAsync();

            var events = new List<Event>();

            foreach (var @event in rsoEvents) {
                events.Add(@event.Event);
            }

            return events;
        }
    }
}
