using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class PublicEventRepository
    {
        private readonly DbSet<PublicEvent> dbSet;

        public PublicEventRepository (CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<PublicEvent>();
        }

        public async Task<IEnumerable<Event>> GetEvents()
        {
            var publicEvents = await this.dbSet.Include(x => x.Event).ToListAsync();


            var events = new List<Event>();

            foreach (var @event in publicEvents) {
                events.Add(@event.Event);
            }

            return events;
        }
    }
}
