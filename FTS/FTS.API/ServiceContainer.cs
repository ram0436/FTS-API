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
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICommercialServiceService, CommercialServiceService>();
            services.AddScoped<IElectricApplianceService, ElectricApplianceService>();

            services.AddScoped<IFashionService, FashionService>();
            services.AddScoped<IFurnitureService, FurnitureService>();
            services.AddScoped<IGadgetService, GadgetService>();
            services.AddScoped<IHobbyService, HobbyService>();

            services.AddScoped<IHouseApartmentService, HouseApartmentService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<ILandPlotService, LandPlotService>();
            services.AddScoped<IOfficeShopService, OfficeShopService>();

            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IPGService, PGService>();
            services.AddScoped<ISportService, SportService>();
            services.AddScoped<IVehicleService, VehicleService>();


            //Repository Container
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICommercialServiceRepository, CommercialServiceRepository>();
            services.AddScoped<IElectricApplianceRepository, ElectricApplianceRepository>();

            services.AddScoped<IFashionRepository, FashionRepository>();
            services.AddScoped<IFurnitureRepository, FurnitureRepository>();
            services.AddScoped<IGadgetRepository, GadgetRepository>();
            services.AddScoped<IHobbyRepository, HobbyRepository>();

            services.AddScoped<IHouseApartmentRepository, HouseApartmentRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<ILandPlotRepository, LandPlotRepository>();
            services.AddScoped<IOfficeShopRepository, OfficeShopRepository>();

            services.AddScoped<IPetRepository, PetRepository>();
            services.AddScoped<IPGRepository, PGRepository>();
            services.AddScoped<ISportRepository, SportRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();

        }
    }
}
