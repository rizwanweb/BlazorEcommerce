﻿using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductServices
{
	public interface IProductService
	{
		event Action ProductsChanged;
		List<Product> Products { get; set; }
		Task GetProducts(string? categoryUrl = null);
		Task<ServiceResponse<Product>> GetSingleProduct(int productID);
	}
}