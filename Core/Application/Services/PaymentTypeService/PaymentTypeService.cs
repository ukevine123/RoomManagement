using Application.DTO;
using Application.Interface;
using Domain.Entities;

namespace Application.Services.PaymentTypeService
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IPaymentType _paymentType;

        public PaymentTypeService(IPaymentType paymentType)
        {
            _paymentType = paymentType;
        }

        public Task<List<PaymentType>> GetAllAsync() => _paymentType.GetAllAsync();

        public Task<PaymentType> GetByIdAsync(int id) => _paymentType.GetByIdAsync(id);

        public Task CreatePaymentTypeAsync(CreatePaymentTypeDTO createPaymentTypeDTO) => _paymentType.CreatePaymentTypeAsync(createPaymentTypeDTO);
    }
}

