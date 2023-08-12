using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Aplication.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		IProductRepository _productsRepository;

		public ProductsController(IProductRepository productsRepository)
		{
			_productsRepository = productsRepository;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await _productsRepository.GetAllAsync());
		}
	}
}
