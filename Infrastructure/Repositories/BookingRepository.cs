using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class BookingRepository : IBooking
    {
        private readonly ApplicationDbContext _context;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Booking>> GetAllAsync()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetByIdAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            return booking ?? throw new KeyNotFoundException($"Booking with ID {id} was not found.");
        }

        public async Task CreateBookingAsync(CreateBookingDTO createBookingDTO)
        {
            var booking = new Booking
            {
                GuestId = createBookingDTO.GuestId,
                RoomId = createBookingDTO.RoomId,
                BookingAmount = createBookingDTO.BookingAmount,
                AmountDue = createBookingDTO.AmountDue,
                CheckInDate = createBookingDTO.CheckInDate,
                CheckOutDate = createBookingDTO.CheckOutDate,
                Status = "pending"
            };

            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();

            // Create allocation linked to the booking
            var allocation = new Allocation
            {
                BookingId = booking.Id,
                RoomId = booking.RoomId,
                CheckInDate = booking.CheckInDate.ToDateTime(TimeOnly.MinValue),
                ExpectedCheckOutDate = booking.CheckOutDate.ToDateTime(TimeOnly.MinValue),
                ActualCheckOutDate = booking.CheckOutDate.ToDateTime(TimeOnly.MinValue),
                Status = "pending"
            };

            await _context.Allocations.AddAsync(allocation);
            await _context.SaveChangesAsync();
        }
    }
}
