using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PaymentRepository : IPayment
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetAllAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> GetByIdAsync(int id)
        {
            var entity = await _context.Payments.FindAsync(id);
            return entity ?? throw new KeyNotFoundException($"Payment with ID {id} was not found.");
        }

        public async Task CreatePaymentAsync(CreatePaymentDTO createPaymentDTO)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == createPaymentDTO.BookingId);
            if (booking is null)
            {
                throw new KeyNotFoundException($"Booking with ID {createPaymentDTO.BookingId} was not found.");
            }

            var amountPaid = createPaymentDTO.AmountPaid;
            var balance = booking.BookingAmount - amountPaid;
            if (balance < 0) balance = 0;

            var payment = new Payment
            {
                BookingId = createPaymentDTO.BookingId,
                AmountPaid = amountPaid,
                Balance = balance,
                PaymentTypeId = createPaymentDTO.PaymentTypeId,
                PaymentDate = createPaymentDTO.PaymentDate
            };

            await _context.Payments.AddAsync(payment);

            // Update booking status based on payment
            if (amountPaid >= booking.BookingAmount)
            {
                booking.Status = "confirmed";
            }

            await _context.SaveChangesAsync();
        }
    }
}

