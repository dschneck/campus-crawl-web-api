using DataAccess.Repositories;

namespace DataAccess.Intefaces
{

    public interface ICampusCrawlUnitOfWork
    {
        Task<int> SaveAllAsync();
        UniversityRepository Universities { get; }
        UserRepository Users { get; }
        RsoRepository RSOs { get; }
        AdminRepository Admins { get; }
        MemberRepository Members { get; }
        PrivateEventRepository PrivateEvents { get; }
        PublicEventRepository PublicEvents { get; }
        RsoEventRepository RsoEvents { get; }
    }
}
