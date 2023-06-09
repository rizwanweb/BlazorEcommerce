﻿using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly DataContext _context;

		public CategoryService(DataContext context)
        {
			_context = context;
		}
        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
		{
			var categories = await _context.Categories.ToListAsync();
			return new ServiceResponse<List<Category>>
			{
				Data = categories
			};			
		}

		public Task<ServiceResponse<Category>> GetCategoryByIdAsync()
		{
			throw new NotImplementedException();
		}
	}
}
