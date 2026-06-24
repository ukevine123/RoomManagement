using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IPayment
    {
        Task<List<Payment>> GetAllAsync();
        Task<Payment> GetByIdAsync(int id);
        Task CreatePaymentAsync(CreatePaymentDTO createPaymentDTO);
    }
}

