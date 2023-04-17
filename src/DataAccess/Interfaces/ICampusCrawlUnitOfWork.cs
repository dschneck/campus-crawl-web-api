namespace DataAccess.Intefaces
{

    public interface ICampusCrawlUnitOfWork
    {
        Task<int> SaveAllAsync();
    }
}
