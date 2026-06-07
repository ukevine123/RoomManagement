using Domain.Entities;

namespace Application.DTO
{
    public class CreateRoomDTO
    {
        public int MaximumOccupancy { get; set; }
        public string RoomCode { get; set; } = string.Empty;
        public string Status { get; set; } = "Available";
        public int RoomCategoryId { get; set; }
        public RoomCategory? RoomCategory { get; set; }
    }
}