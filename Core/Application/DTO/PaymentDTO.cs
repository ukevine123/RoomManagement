using System;

namespace Application.DTO
{
    public class CreatePaymentDTO
    {
        public int BookingId { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public class PaymentDTO
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}

