using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.ProductServices
{
	public class ProductService : IProductService
	{
		private readonly DataContext _context;

		public ProductService(DataContext context) 
		{
			_context = context;
		}

		public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
		{
			var response = new ServiceResponse<List<Product>>()
			{
				Data = await _context.Products.Include(p => p.Variants).ToListAsync(),
			};
			return response;
		}

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
			var response = new ServiceResponse<List<Product>>
			{
				Data = await _context.Products
					.Include(p => p.Category)
					.Where(p => p.Category.Url.ToLower() == categoryUrl.ToLower())
					.ToListAsync()
			};
			return response;
        }

        public async Task<ServiceResponse<Product>> GetSingleProductAsync(int productID)
		{
			var response = new ServiceResponse<Product>();
			var product = await _context.Products
				.Include(c => c.Category)
				.Include(p => p.Variants)
				.ThenInclude(v => v.ProductType)
				.FirstOrDefaultAsync(p => p.Id == productID);
			if (product == null)
			{
				response.Success = false;
				response.Message = "This Product does not exist";
			}
			else 
			{
				response.Data = product;				
			}
			return response;
		}


    }
}
