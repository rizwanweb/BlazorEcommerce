using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly HttpClient _http;
		public List<Category> Categories { get; set; } = new List<Category>();
		public CategoryService(HttpClient http)
        {
			_http = http;
		}        

		public async Task GetCategories()
		{
			var results =
				await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
			if (results != null && results.Data != null)
			{
				Categories = results.Data;
			}
		}
	}
}
