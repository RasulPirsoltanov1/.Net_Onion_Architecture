using AutoMapper;
using MediatR;
using ProductApp.Aplication.DTO;
using ProductApp.Aplication.Interfaces.Repository;

namespace ProductApp.Aplication.Features.Queries.Prroduct
{
	public class GetAllProductRequestHandler : IRequestHandler<GetAllProductRequest, List<ProductViewDTO>>
	{
		IProductRepository _productRepository;
		IMapper _mapper;

		public GetAllProductRequestHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public async Task<List<ProductViewDTO>> Handle(GetAllProductRequest request, CancellationToken cancellationToken)
		{
			var values = await _productRepository.GetAllAsync();
			var result=_mapper.Map<List<ProductViewDTO>>(values);
			return result;
		}
	}
}
