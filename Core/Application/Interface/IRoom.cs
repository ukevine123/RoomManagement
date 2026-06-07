using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface IRoom
    {
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(int id);
        Task CreateRoomAsync(CreateRoomDTO createRoomDTO);
    }
}
