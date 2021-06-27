using FTS.Repository.IRepositories;
using FTS.Repository.Repositories;
using FTS.Service.IServices;
using FTS.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FTS.API
{
    public static class ServiceContainer
    {
        public static void AddService(this IServiceCollection services)
        {
            // Service Container
            services.AddScoped<IUserService, UserService>();

            //Repository Container
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
