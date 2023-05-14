namespace BlazorEcommerce.Server.Services.ProductServices
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryURL);
        Task<ServiceResponse<Product>> GetSingleProductAsync(int productID);
		Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);
		Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
		
	}
}