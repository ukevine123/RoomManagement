using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GuestRepository : IGuest
    {
        private readonly ApplicationDbContext _context;

        public GuestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Guest>> GetAllAsync()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest> GetByIdAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            return guest ?? throw new KeyNotFoundException($"Guest with ID {id} was not found.");
        }

        public async Task CreateGuestAsync(CreateGuestDTO createGuestDTO)
        {
            var guest = new Guest
            {
                FullName = createGuestDTO.FullName,
                Email = createGuestDTO.Email,
                Phone = createGuestDTO.Phone,
                Sex = createGuestDTO.Sex,
                Address = createGuestDTO.Address
            };

            await _context.Guests.AddAsync(guest);
            await _context.SaveChangesAsync();
        }
    }
}
