using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PaymentTypeRepository : IPaymentType
    {
        private readonly ApplicationDbContext _context;

        public PaymentTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentType>> GetAllAsync()
        {
            return await _context.PaymentTypes.ToListAsync();
        }

        public async Task<PaymentType> GetByIdAsync(int id)
        {
            var entity = await _context.PaymentTypes.FindAsync(id);
            return entity ?? throw new KeyNotFoundException($"PaymentType with ID {id} was not found.");
        }

        public async Task CreatePaymentTypeAsync(CreatePaymentTypeDTO createPaymentTypeDTO)
        {
            var entity = new PaymentType
            {
                Name = createPaymentTypeDTO.Name
            };

            await _context.PaymentTypes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}

