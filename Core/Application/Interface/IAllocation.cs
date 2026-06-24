using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IAllocation
    {
        Task<List<Allocation>> GetAllAsync();
        Task<Allocation> GetByIdAsync(int id);
        Task CreateAllocationAsync(CreateAllocationDTO createAllocationDTO);
    }
}

