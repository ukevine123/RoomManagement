using Application.DTO;
using Domain.Entities;

namespace Application.Services.RoomService
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(int id);
        Task CreateRoomAsync(CreateRoomDTO createRoomDTO);
    }
}
