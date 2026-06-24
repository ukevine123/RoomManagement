using Application.DTO;
using Domain.Entities;
using Application.Interface;

namespace Application.Services.AllocationService
{
    public class AllocationService : IAllocationService
    {
        private readonly IAllocation _allocation;

        public AllocationService(IAllocation allocation)
        {
            _allocation = allocation;
        }

        public async Task<List<Allocation>> GetAllAsync()
        {
            return await _allocation.GetAllAsync();
        }

        public async Task<Allocation> GetByIdAsync(int id)
        {
            return await _allocation.GetByIdAsync(id);
        }

        public async Task CreateAllocationAsync(CreateAllocationDTO createAllocationDTO)
        {
            await _allocation.CreateAllocationAsync(createAllocationDTO);
        }
    }
}
