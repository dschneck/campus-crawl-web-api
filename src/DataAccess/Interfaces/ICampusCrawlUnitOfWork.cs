using DataAccess.Repositories;

namespace DataAccess.Intefaces
{

    public interface ICampusCrawlUnitOfWork
    {
        Task<int> SaveAllAsync();
        UniversityRepository university { get; }
    }
}
