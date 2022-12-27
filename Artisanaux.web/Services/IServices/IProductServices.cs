using Artisanaux.Web.Models;

namespace Artisanaux.web.Services.IServices
{
    public interface IProductServices : IBaseServices
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id , string token);
        Task<T> CreateProductsAsync<T>(ProductDto productDto , string token);

        Task<T> UpdateProductsAsync<T>(ProductDto productDto, string token);
        Task<T> DeleteProductsAsync<T>(int id , string token);
    }
}
