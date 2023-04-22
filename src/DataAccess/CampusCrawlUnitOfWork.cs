using DataAccess.Intefaces;
using DataAccess.Repositories;

namespace DataAccess
{
    public class CampusCrawlUnitOfWork : ICampusCrawlUnitOfWork, IDisposable
    {
        private readonly CampusCrawlDbContext dbContext;
        private bool disposed = false;
        private UniversityRepository uniRepo;
        private UserRepository userRepo;
        private AdminRepository adminRepo;
        private RsoRepository rsoRepo;
        private MemberRepository memberRepo;
        private RsoEventRepository rsoEventRepo;
        private PrivateEventRepository privateEventRepo;
        private PublicEventRepository publicEventRepo;

        public UniversityRepository Universities
        {
            get
            {
                return this.uniRepo ??= new UniversityRepository(this.dbContext);
            }
        }

        public UserRepository Users
        {
            get
            {
                return this.userRepo ??= new UserRepository(this.dbContext);
            }
        }


        public AdminRepository Admins
        {
            get
            {
                return this.adminRepo ??= new AdminRepository(this.dbContext);
            }
        }

        public RsoRepository RSOs
        {
            get
            {
                return this.rsoRepo ??= new RsoRepository(this.dbContext);
            }
        }

        public MemberRepository Members
        {
            get
            {
                return this.memberRepo ??= new MemberRepository(this.dbContext);
            }
        }


        public RsoEventRepository RsoEvents
        {
            get
            {
                return this.rsoEventRepo ??= new RsoEventRepository(this.dbContext);
            }
        }

        public PublicEventRepository PublicEvents
        {
            get
            {
                return this.publicEventRepo ??= new PublicEventRepository(this.dbContext);
            }
        }

        public PrivateEventRepository PrivateEvents
        {
            get
            {
                return this.privateEventRepo ??= new PrivateEventRepository(this.dbContext);
            }
        }

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
