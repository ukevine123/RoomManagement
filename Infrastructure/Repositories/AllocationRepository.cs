using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AllocationRepository : IAllocation
    {
        private readonly ApplicationDbContext _context;

        public AllocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Allocation>> GetAllAsync()
        {
            return await _context.Allocations.ToListAsync();
        }

        public async Task<Allocation> GetByIdAsync(int id)
        {
            var allocation = await _context.Allocations.FindAsync(id);
            return allocation ?? throw new KeyNotFoundException($"Allocation with ID {id} was not found.");
        }

        public async Task CreateAllocationAsync(CreateAllocationDTO createAllocationDTO)
        {
            var allocation = new Allocation
            {
                BookingId = createAllocationDTO.BookingId,
                RoomId = createAllocationDTO.RoomId,
                CheckInDate = createAllocationDTO.CheckInDate,
                ExpectedCheckOutDate = createAllocationDTO.ExpectedCheckOutDate,
                ActualCheckOutDate = createAllocationDTO.ActualCheckOutDate,
                Status = createAllocationDTO.Status
            };

            await _context.Allocations.AddAsync(allocation);
            await _context.SaveChangesAsync();
        }
    }
}

