using Application.DTO;
using Domain.Entities;
using Application.Interface;

namespace Application.Services.RoomCategoryService
{
    public class RoomCategoryService : IRoomCategoryService
    {
        //Dependency Injection
        private readonly IRoomCategory _roomCategory;

        //Constructor
        public RoomCategoryService(IRoomCategory roomCategory)
        {
            _roomCategory = roomCategory;
        }

        //Get All
        public async Task<List<RoomCategory>> GetAllAsync()
        {
            return await _roomCategory.GetAllAsync();
        }

        //Get By Id
        public async Task<RoomCategory> GetByIdAsync(int id)
        {
            return await _roomCategory.GetByIdAsync(id);
        }

        //Create
        public async Task CreateRoomCategoryAsync(CreateRoomCategoryDTO createRoomCategoryDTO)
        {
            await _roomCategory.CreateRoomCategoryAsync(createRoomCategoryDTO);
        }

    }
}