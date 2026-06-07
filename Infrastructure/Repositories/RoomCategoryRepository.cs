using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomCategoryRepository : IRoomCategory
    {
        private readonly ApplicationDbContext _context;

        public RoomCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<RoomCategory>> GetAllAsync()
        {
            return await _context.RoomCategories.ToListAsync();
        }

        public async Task<RoomCategory> GetByIdAsync(int id)
        {
            var roomCategory = await _context.RoomCategories.FindAsync(id);
            return roomCategory ?? throw new KeyNotFoundException($"RoomCategory with ID {id} was not found.");
        }

        public async Task CreateRoomCategoryAsync(CreateRoomCategoryDTO createRoomCategoryDTO)
        {
            var roomCategory = new RoomCategory 
            { 
                Name = createRoomCategoryDTO.Name,
                Description = createRoomCategoryDTO.Description,
                PricePerDay = createRoomCategoryDTO.PricePerDay
                
            };
            
            await _context.RoomCategories.AddAsync(roomCategory);
            await _context.SaveChangesAsync();
        }

    }
}
