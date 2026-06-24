namespace Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType Name { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}