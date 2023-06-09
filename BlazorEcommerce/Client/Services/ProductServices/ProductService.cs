﻿using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductServices
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _http;
		public List<Product> Products { get; set; } = new List<Product>();
		public string message { get; set; } = "Loading Products";

		public event Action ProductsChanged;

		public ProductService(HttpClient http)
        {
			_http = http;
		}

		public async Task GetProducts(string? categoryUrl = null)
		{
			var result = categoryUrl == null ?
				await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
				await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
			
			if (result != null && result.Data != null) 
			{
				Products = result.Data;
			}
			ProductsChanged.Invoke();
		}

		public async Task<ServiceResponse<Product>> GetSingleProduct(int productID)
		{
			var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productID}");
			return result;
		}

		public async Task SearchProducts(string searchText)
		{
			var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchText}");
			if (result != null && result.Data != null)
			{
				Products = result.Data;
			}
			if (Products.Count == 0) message = "No Products Found";
			ProductsChanged?.Invoke();
		}

		public async Task<List<string>> GetProductSearchSuggestions(string searchText)
		{
			var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");
			return result.Data;
		}
	}
}
