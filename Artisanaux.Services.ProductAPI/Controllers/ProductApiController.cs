using Artisanaux.Services.ProductAPI.Models.Dto;
using Artisanaux.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artisanaux.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]

        public async Task<object> Get()
        {
            IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
            return Ok(productDtos);
        }


        [HttpGet]
        [Route("{id}")]

        public async Task<object> GetById(int id)
        {
            ProductDto productDtos = await _productRepository.GetProductById(id);
            return Ok(productDtos);
        }



        [HttpDelete]
        [Route("{id}")]
        public Task<bool> delete(int id)
        {
          return _productRepository.DeleteProduct(id);
            
            
        }

    }
}
