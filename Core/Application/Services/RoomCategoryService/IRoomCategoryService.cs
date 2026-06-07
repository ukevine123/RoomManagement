using Application.DTO;
using Domain.Entities;

namespace Application.Services.RoomCategoryService
{
    public interface IRoomCategoryService
    {
        Task<List<RoomCategory>> GetAllAsync();
        Task<RoomCategory> GetByIdAsync(int id);
        Task CreateRoomCategoryAsync(CreateRoomCategoryDTO createRoomCategoryDTO);
        // Task UpdateRoomCategoryAsync(UpdateRoomCategoryDTO updateRoomCategoryDTO);
        // Task DeleteRoomCategoryAsync(int id);
    }
}
