using AutoMapper;
using MediatR;
using ProductApp.Aplication.DTO;
using ProductApp.Aplication.Interfaces.Repository;

namespace ProductApp.Aplication.Features.Queries.GetProductById
{
	public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, ProductViewDTO>
	{
		IProductRepository _productRepository;
		IMapper _mapper;

		public GetProductByIdRequestHandler(IProductRepository productRepository, IMapper mapper)
		{
			this._productRepository = productRepository;
			_mapper = mapper;
		}

		public async Task<ProductViewDTO> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
		{
			var values = await _productRepository.GetByIdAsync(request.Id);
			return _mapper.Map<ProductViewDTO>(values);
		}
	}
}
