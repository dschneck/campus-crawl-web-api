using DataAccess.Repositories;

namespace DataAccess.Intefaces
{

    public interface ICampusCrawlUnitOfWork
    {
        Task<int> SaveAllAsync();
        UniversityRepository Universities { get; }
        UserRepository Users { get; }
    }
}
