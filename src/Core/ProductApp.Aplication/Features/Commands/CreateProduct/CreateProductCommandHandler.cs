using AutoMapper;
using MediatR;
using ProductApp.Aplication.Interfaces.Repository;

namespace ProductApp.Aplication.Features.Commands.CreateProduct
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Guid>
	{
		IProductRepository _productRepository;

		public CreateProductCommandHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public async Task<Guid> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
		{
			var entity = await _productRepository.AddAsync(new Domain.Entities.Product
			{
				Id = Guid.NewGuid(),
				CreateDate = DateTime.Now,
				Name = request.Name,
				Quantity = request.Quantity,
				Value = request.Value
			});
			await _productRepository.SaveChangesAsync();
			return entity.Id;
		}
	}
}
