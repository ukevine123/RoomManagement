using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.Interface;
using Infrastructure.Repositories;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            // Add infrastructure services here, e.g., DbContext, Repositories, etc.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("RoomManagementConnection"))
            );

            services.AddScoped<IRoomCategory, RoomCategoryRepository>();
            services.AddScoped<IRoom, RoomRepository>();
            services.AddScoped<IGuest, GuestRepository>();

            return services;
        }
    }
}
