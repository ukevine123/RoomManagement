using Application.DTO;
using Domain.Entities;
using Application.Interface;

namespace Application.Services.GuestService
{
    public class GuestService : IGuestService
    {
        private readonly IGuest _guestRepository;

        public GuestService(IGuest guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async Task<List<Guest>> GetAllAsync()
        {
            return await _guestRepository.GetAllAsync();
        }

        public async Task<Guest> GetByIdAsync(int id)
        {
            return await _guestRepository.GetByIdAsync(id);
        }

        public async Task CreateGuestAsync(CreateGuestDTO createGuestDTO)
        {
            await _guestRepository.CreateGuestAsync(createGuestDTO);
        }
    }
}
