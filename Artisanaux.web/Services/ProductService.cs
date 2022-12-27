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
       

        public async Task<T> CreateProductsAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.POST,
                Data= productDto,
                url = SD.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> DeleteProductsAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.DELETE,
                url = SD.ProductAPIBase + "/api/products/"+id,
                AccessToken = token
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
           return await this.SendAsync<T>(new ApiRequest()
            { 
                apiType = SD.ApiType.GET,
                url = SD.ProductAPIBase + "/api/products",
               });
        }

        public async Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.GET,
                url = SD.ProductAPIBase + "/api/products/"+id,
                AccessToken = token
            });
        }

        public async Task<T> UpdateProductsAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.PUT,
                Data = productDto,
                url = SD.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }
    }
}
