using Application.DTO;
using Domain.Entities;

namespace Application.Services.GuestService
{
    public interface IGuestService
    {
        Task<List<Guest>> GetAllAsync();
        Task<Guest> GetByIdAsync(int id);
        Task CreateGuestAsync(CreateGuestDTO createGuestDTO);
    }
}
