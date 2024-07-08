using MultiShop.Catalog.Dtos.ProdustDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GettAllProductDetailAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string id);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
        Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id);
        Task CreateCategoriAsync(CreateProductDetailDto createProductDetailDto);
        Task DeleteCategoriAsync(string id);
        Task UpdateCategoriAsync(UpdateProductDetailDto updateProductDetailDto);
        Task GettAllCateforyAsync();
    }
}
