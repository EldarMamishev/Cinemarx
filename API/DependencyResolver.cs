using Business.EntityService;
using Business.EntityService.Interface;
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
            services.AddTransient<ICinemaRepository, CinemaRepository>();
            services.AddTransient<IFilmRepository, FilmRepository>();
            services.AddTransient<ICinemaNetworkRepository, CinemaNetworkRepository>();
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<ICinemaService, CinemaService>();
            services.AddTransient<IFilmService, FilmService>();
        }
    }
}
