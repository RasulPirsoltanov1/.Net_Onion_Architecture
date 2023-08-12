using ProductApp.Aplication.Interfaces.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Perisistance.Context;
using ProductApp.Perisistance.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Perisistance.Repository
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
