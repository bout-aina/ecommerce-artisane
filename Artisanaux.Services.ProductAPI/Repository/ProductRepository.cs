using Artisanaux.Services.ProductAPI.Models.Dto;

namespace Artisanaux.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<ProductDto> CreateUpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
