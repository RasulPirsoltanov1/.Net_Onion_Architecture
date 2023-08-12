using MediatR;
using ProductApp.Aplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Queries.Prroduct
{
	public class GetAllProductRequest:IRequest<List<ProductViewDTO>>
	{
	}
}
