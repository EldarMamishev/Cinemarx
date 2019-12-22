using Data;
using Data.Repository;
using Data.UnitOfWork;
using Data.UnitOfWork.Interface;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public static class DependencyResolver
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            services.AddTransient<DbContext, CinemarxContext>();
            DependencyResolver.ConfigureEntities(services);
            DependencyResolver.ConfigureServices(services);
        }

        static void ConfigureEntities(IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        static void ConfigureServices(IServiceCollection services)
        {

        }
    }
}
