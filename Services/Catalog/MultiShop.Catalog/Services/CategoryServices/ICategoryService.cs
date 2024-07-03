using MultiShop.Catalog.Dtos.CategoryDtos;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GettAllCateforyAsync();
        Task CreateCategoriAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoriAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoriAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);

    }
}
