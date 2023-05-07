using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{		
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
        {			
			_productService = productService;
		}


        [HttpGet]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
		{
			var result = await _productService.GetProductsAsync();
			return Ok(result);
		}

		[HttpGet("{productID}")]
		public async Task<ActionResult<ServiceResponse<Product>>> GetSingleProduct(int productID)
		{
			var result = await _productService.GetSingleProductAsync(productID);
			return Ok(result);
		}
		
		[HttpGet("category/{categoryUrl}")]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
		{
            var result = await _productService.GetProductsByCategoryAsync(categoryUrl);
            return Ok(result);
        }


	}
}
