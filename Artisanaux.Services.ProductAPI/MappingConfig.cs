using Artisanaux.Services.ProductAPI.Models;
using Artisanaux.Services.ProductAPI.Models.Dto;
using AutoMapper;

namespace Artisanaux.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();


            });
            return mappingConfig;
        }
    }
}
