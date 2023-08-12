using MediatR;
using ProductApp.Aplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Queries.GetProductById
{
	public class GetProductByIdRequest : IRequest<ProductViewDTO>
	{
		public GetProductByIdRequest(string id)
		{
			Id = id;
		}
		public string Id { get; set; }
	}
}
