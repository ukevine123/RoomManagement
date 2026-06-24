using Application.DTO;
using Application.Interface;
using Domain.Entities;

namespace Application.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly IPayment _payment;

        public PaymentService(IPayment payment)
        {
            _payment = payment;
        }

        public Task<List<Payment>> GetAllAsync() => _payment.GetAllAsync();

        public Task<Payment> GetByIdAsync(int id) => _payment.GetByIdAsync(id);

        public Task CreatePaymentAsync(CreatePaymentDTO createPaymentDTO) => _payment.CreatePaymentAsync(createPaymentDTO);
    }
}

