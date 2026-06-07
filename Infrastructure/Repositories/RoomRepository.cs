using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomRepository : IRoom
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await _context.Rooms
                .Include(r => r.RoomCategory)
                .ToListAsync();
        }

        public async Task<Room> GetByIdAsync(int id)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomCategory)
                .FirstOrDefaultAsync(r => r.Id == id);
            return room ?? throw new KeyNotFoundException($"Room with ID {id} was not found.");
        }

        public async Task CreateRoomAsync(CreateRoomDTO createRoomDTO)
        {
            var room = new Room
            {
                MaximumOccupancy = createRoomDTO.MaximumOccupancy,
                RoomCode = createRoomDTO.RoomCode,
                Status = createRoomDTO.Status,
                RoomCategoryId = createRoomDTO.RoomCategoryId
            };

            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }
    }
}
