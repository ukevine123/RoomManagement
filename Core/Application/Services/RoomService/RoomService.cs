using Application.DTO;
using Domain.Entities;
using Application.Interface;

namespace Application.Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly IRoom _room;

        public RoomService(IRoom room)
        {
            _room = room;
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await _room.GetAllAsync();
        }

        public async Task<Room> GetByIdAsync(int id)
        {
            return await _room.GetByIdAsync(id);
        }

        public async Task CreateRoomAsync(CreateRoomDTO createRoomDTO)
        {
            await _room.CreateRoomAsync(createRoomDTO);
        }
    }
}
