using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface ICarsService
    {
        Task<IEnumerable<CarDto>> GetAll();
        Task<IEnumerable<CarDto>> Get(IEnumerable<int> ids);
        Task<CarDto?> Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        void Create(CreateCarModel product);
        void Edit(CarDto product);
        void Delete(int id);
    }
}
