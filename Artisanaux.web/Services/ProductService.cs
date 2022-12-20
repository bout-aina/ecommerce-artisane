using Artisanaux.web.Models;
using Artisanaux.web.Services.IServices;
using Artisanaux.Web.Models;
using Microsoft.Win32.SafeHandles;

namespace Artisanaux.web.Services
{
    public class ProductService : BaseService, IProductServices
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {
            _clientFactory= httpClient;
        }
       

        public Task<T> CreateProductsAsync<T>(ProductDto productDto, string token)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteProductsAsync<T>(int id, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAllProductsAsync<T>(string token)
        {
           return await this.SendAsync<T>(new ApiRequest()
            { 
                apiType = SD.ApiType.GET,
                url = SD.ProductAPIBase + "/api/products",
                AccessToken = token});
        }

        public Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateProductsAsync<T>(ProductDto productDto, string token)
        {
            throw new NotImplementedException();
        }
    }
}
