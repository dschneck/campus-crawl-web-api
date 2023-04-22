using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class PrivateEventRepository
    {
        private readonly DbSet<PrivateEvent> dbSet;

        public PrivateEventRepository (CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<PrivateEvent>();
        }

        public async Task<IEnumerable<Event>> GetEventsByUniversityId(string universityId)
        {
            var privateEvents = await this.dbSet.Include(x => x.Event).ToListAsync();

            var events = new List<Event>();

            foreach (var @event in privateEvents) {
                events.Add(@event.Event);
            }

            return events;
        }
    }
}
