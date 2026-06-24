using Application.DTO;
using Domain.Entities;

namespace Application.Services.AllocationService
{
    public interface IAllocationService
    {
        Task<List<Allocation>> GetAllAsync();
        Task<Allocation> GetByIdAsync(int id);
        Task CreateAllocationAsync(CreateAllocationDTO createAllocationDTO);
    }
}

