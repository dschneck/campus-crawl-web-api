namespace campus_crawl_web_api.DataAccess
{

    public interface IRepository<TEntity> {
        Task<IEnumerable<TEntity>> GetEntites();
        Task<TEntity> GetEntityById(string id);
        Task<bool> UpdateEntity(TEntity entity);
        Task<bool> DeleteEntity(TEntity entity);
        Task<bool> InsertEntity(TEntity entity);
    }
}
