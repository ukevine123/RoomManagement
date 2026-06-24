using Application.DTO;
using Domain.Entities;
using Application.Interface;

namespace Application.Services.BookingService
{
    public class BookingService : IBookingService
    {
        private readonly IBooking _booking;

        public BookingService(IBooking booking)
        {
            _booking = booking;
        }

        public async Task<List<Booking>> GetAllAsync()
        {
            return await _booking.GetAllAsync();
        }

        public async Task<Booking> GetByIdAsync(int id)
        {
            return await _booking.GetByIdAsync(id);
        }

        public async Task CreateBookingAsync(CreateBookingDTO createBookingDTO)
        {
            await _booking.CreateBookingAsync(createBookingDTO);
        }
    }
}
