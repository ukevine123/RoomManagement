using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.Interface;
using Application.Services.AllocationService;
using Application.Services.PaymentService;
using Application.Services.PaymentTypeService;
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
            services.AddScoped<IBooking, BookingRepository>();
            services.AddScoped<IAllocation, AllocationRepository>();
            services.AddScoped<IPayment, PaymentRepository>();
            services.AddScoped<IPaymentType, PaymentTypeRepository>();


            return services;
        }
    }
}
