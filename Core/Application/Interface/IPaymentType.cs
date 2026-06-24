using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IPaymentType
    {
        Task<List<PaymentType>> GetAllAsync();
        Task<PaymentType> GetByIdAsync(int id);
        Task CreatePaymentTypeAsync(CreatePaymentTypeDTO createPaymentTypeDTO);
    }
}

