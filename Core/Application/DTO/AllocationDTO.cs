using System;
using Domain.Entities;

namespace Application.DTO
{
    public class CreateAllocationDTO
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime ExpectedCheckOutDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class AllocationDTO
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime ExpectedCheckOutDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        public string Status { get; set; }

        // public static AllocationDTO FromEntity(Allocation allocation) => new()
        // {
        //     Id = allocation.Id,
        //     BookingId = allocation.BookingId,
        //     RoomId = allocation.RoomId,
        //     CheckInDate = allocation.CheckInDate,
        //     ExpectedCheckOutDate = allocation.ExpectedCheckOutDate,
        //     ActualCheckOutDate = allocation.ActualCheckOutDate,
        //     Status = allocation.Status
        // };
    }
}

