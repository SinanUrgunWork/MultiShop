using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GettAllCateforyAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
        Task CreateCategoriAsync(CreateProductImageDto createProductImageDto);
        Task DeleteCategoriAsync(string id);
        Task UpdateCategoriAsync(UpdateProductImageDto updateProductImageDto);
    }
}
