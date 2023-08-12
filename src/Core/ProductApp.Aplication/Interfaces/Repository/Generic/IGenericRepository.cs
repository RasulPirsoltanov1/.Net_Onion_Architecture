using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Interfaces.Repository.Generic
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		DbSet<T> Table { get; }
		Task<T> AddAsync(T entity);
		Task<List<T>> GetAllAsync();
		Task<T> GetByIdAsync(string id);
		Task<List<T>> GetbyFilter(Expression<Func<T,bool>> expression);
		void Delete(T entity);
		void Update(T entity);
		Task SaveChangesAsync();
	}
}
