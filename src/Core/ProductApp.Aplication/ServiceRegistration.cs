using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Aplication.Features.Queries.Prroduct;
using ProductApp.Aplication.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication
{
	public static class ServiceRegistration
	{
		public static void ApplicationServiceRegistration(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(GeneralMapping).Assembly);
			services.AddMediatR(typeof(GetAllProductRequest).Assembly);
		}
	}
}
