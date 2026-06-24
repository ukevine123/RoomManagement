using Application.DTO;
using Domain.Entities;

namespace Application.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetAllAsync();
        Task<Payment> GetByIdAsync(int id);
        Task CreatePaymentAsync(CreatePaymentDTO createPaymentDTO);
    }
}

