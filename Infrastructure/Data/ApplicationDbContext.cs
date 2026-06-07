using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<RoomCategory> RoomCategories => Set<RoomCategory>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Guest> Guests => Set<Guest>();

    }
}