using DataAccess.Intefaces;

namespace DataAccess
{
    public class CampusCrawlUnitOfWork : ICampusCrawlUnitOfWork, IDisposable
    {
        private readonly CampusCrawlDbContext dbContext;
        private bool disposed = false;

        public CampusCrawlUnitOfWork(CampusCrawlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> SaveAllAsync()
        {
            return await this.dbContext.SaveChangesAsync();
        }

        public  void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                this.dbContext.Dispose();
            }

            this.disposed = true;
        }
    }
}
