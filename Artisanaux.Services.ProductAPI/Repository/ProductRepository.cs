using Artisanaux.Services.ProductAPI.DbContexts;
using Artisanaux.Services.ProductAPI.Models;
using Artisanaux.Services.ProductAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using System;
using Product = Artisanaux.Services.ProductAPI.Models.Product;

namespace Artisanaux.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            Product? product = await _db.Products!.Where(x => x.ProductId == productId).FirstOrDefaultAsync();

            if (product != null)
            {
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;



           
           
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            if (product != null)
            {
                ProductDto productDto = _mapper.Map<ProductDto>(product);
                return productDto;
            }
            return await Task.FromResult<ProductDto>(null!);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> products = await _db.Products!.ToListAsync();

            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
