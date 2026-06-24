namespace Domain.Entities
{
    public class Allocation
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime ExpectedCheckOutDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        public string Status { get; set; }
    }
}