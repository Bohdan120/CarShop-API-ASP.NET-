using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface ICarsService
    {
        Task<(IEnumerable<CarDto> Cars, int TotalCount)> GetAll(int page, int pageSize, string? make, string? category, string? sortDirection);
        Task<IEnumerable<CarDto>> Get(IEnumerable<int> ids);
        Task<CarDto?> Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        void Create(CreateCarModel product);
        void Edit(CarDto product);
        void Delete(int id);
        public Task<int> GetTotalCount();
        public IEnumerable<string> GetAllMakes();

    }
}
