

using SampleBLL.Interfaces;
using SampleBLL.Service;
using SampleDAL.Repository;

namespace SampleAPI.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IDBRepository<>), typeof(DBRepository<>)); // Register DBRepository<TEntity>
        }

        public static void AddRepoServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}