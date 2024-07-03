using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GettAllCateforyAsync();
        Task CreateCategoriAsync(CreateProductDto createProductDto);
        Task UpdateCategoriAsync(UpdateProductDto updateProductDto);
        Task DeleteCategoriAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
