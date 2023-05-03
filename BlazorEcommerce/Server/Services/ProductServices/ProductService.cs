﻿using BlazorEcommerce.Server.Data;
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
				Data = await _context.Products.ToListAsync(),
			};
			return response;
		}
	}
}