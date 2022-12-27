using Artisanaux.web.Services.IServices;
using Artisanaux.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Artisanaux.web.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
                _productServices = productServices;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list= new List<ProductDto>();
            var response = await _productServices.GetAllProductsAsync<ResponseDto>();
            if(response!=null)
            {

            }
            
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
                return View(list);
            
           
        }
    }
}
