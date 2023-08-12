using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Aplication.Features.Commands.CreateProduct;
using ProductApp.Aplication.Features.Queries.GetProductById;
using ProductApp.Aplication.Features.Queries.Prroduct;
using ProductApp.Aplication.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		IProductRepository _productsRepository;
		IMediator _mediator;

		public ProductsController(IProductRepository productsRepository, IMediator mediator)
		{
			_productsRepository = productsRepository;
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await _mediator.Send(new GetAllProductRequest()));
		}
		[HttpGet("[action]")]
		public async Task<IActionResult> GetById(string id)
		{
			return Ok(await _mediator.Send(new GetProductByIdRequest(id)));
		}
		[HttpPost]
		public async Task<IActionResult> Add(CreateProductCommandRequest createProductCommandRequest)
		{
			return Ok(await _mediator.Send(createProductCommandRequest));
		}
	}
}