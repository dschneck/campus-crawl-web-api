using DataAccess.Entities;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class UserRepository
    {
        private readonly DbSet<User> dbSet;

        public UserRepository(CampusCrawlDbContext dbContext)
        {
            this.dbSet = dbContext.Set<User>();
        }

        public async Task<User> CreateUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            await this.dbSet.AddAsync(user);
            return user;
        }

        public Task<User> GetUserFromCredentials(UserCredentials userCred)
        {
            return this.dbSet.FirstOrDefaultAsync(x => x.Email == userCred.email && x.Password == userCred.password);
        }
    }
}
