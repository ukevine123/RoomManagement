using Domain.Entities;

namespace Application.DTO
{
    public class CreateBookingDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? RoomCode { get; set; }
        public int GuestId { get; set; }
        public Guest? FullName { get; set; }
        public decimal BookingAmount { get; set; }
        public decimal AmountDue { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public string Status { get; set; }
    }
}