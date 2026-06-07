namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int MaximumOccupancy { get; set; }
        public string RoomCode { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int RoomCategoryId { get; set; }
        public RoomCategory? RoomCategory { get; set; }
    }
}