using Microsoft.Extensions.DependencyInjection;
using Google.Cloud.EntityFrameworkCore.Spanner.Extensions;
using DataAccess.Intefaces;

namespace DataAccess.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CampusCrawlDbContext>(x => x.UseSpanner(connectionString));
            services.AddScoped<ICampusCrawlUnitOfWork, CampusCrawlUnitOfWork>();
            return services;
        }
    }
}
