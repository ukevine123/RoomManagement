using Application.DTO;
using Domain.Entities;

namespace Application.Services.PaymentTypeService
{
    public interface IPaymentTypeService
    {
        Task<List<PaymentType>> GetAllAsync();
        Task<PaymentType> GetByIdAsync(int id);
        Task CreatePaymentTypeAsync(CreatePaymentTypeDTO createPaymentTypeDTO);
    }
}

