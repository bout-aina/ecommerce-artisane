using System.ComponentModel.DataAnnotations;

namespace Artisanaux.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        
        public int ProductId { get; set; }
       
        public string ProductName { get; set; }
       
        public Double Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
