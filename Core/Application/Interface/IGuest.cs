using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IGuest
    {
        Task<List<Guest>> GetAllAsync();
        Task<Guest> GetByIdAsync(int id);
        Task CreateGuestAsync(CreateGuestDTO createGuestDTO);
    }
}
