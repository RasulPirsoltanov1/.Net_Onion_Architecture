using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Aplication.Interfaces.Repository;
using ProductApp.Perisistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Perisistance
{
	public static class ServiceRegistration
	{
		public static void AddPersisitanceServices(this IServiceCollection Services)
		{
			Services.AddScoped<IProductRepository,IProductRepository>();
			Services.AddDbContext<AppDbContext>(opt =>
			{
				opt.UseInMemoryDatabase("memoryDB");
			});
		}
	}
}
