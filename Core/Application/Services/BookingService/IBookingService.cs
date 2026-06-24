using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IBookingService
    {
        Task<List<Booking>> GetAllAsync();
        Task<Booking> GetByIdAsync(int id);
        Task CreateBookingAsync(CreateBookingDTO createBookingDTO);
    }
}
