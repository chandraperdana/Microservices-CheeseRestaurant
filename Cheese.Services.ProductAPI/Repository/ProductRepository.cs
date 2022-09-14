using AutoMapper;
using Cheese.Services.ProductAPI.DbContexts;
using Cheese.Services.ProductAPI.Models;
using Cheese.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cheese.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = mapper.Map<ProductDto, Product>(productDto);
            if (product.ProductId > 0)
            {
                db.Products.Update(product);
            }
            else
            {
                db.Products.Add(product);
            }
            await db.SaveChangesAsync();
            return mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                db.Products.Remove(product);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await db.Products.Where(x=>x.ProductId==productId).FirstOrDefaultAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await db.Products.ToListAsync();
            return mapper.Map<List<ProductDto>>(productList);
        }
    }
}
