using Microsoft.EntityFrameworkCore;
using ProductApp.Aplication.Interfaces.Repository.Generic;
using ProductApp.Domain.Common;
using ProductApp.Perisistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Perisistance.Repository.Generic
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		public AppDbContext _appDbContext { get; set; }
		public DbSet<T> Table => _appDbContext.Set<T>();

		public GenericRepository(AppDbContext appDbContext)
		{
			this._appDbContext = appDbContext;
		}

		public async Task<T> AddAsync(T entity)
		{
			await _appDbContext.AddAsync(entity);

			return entity;
		}

		public void Delete(T entity)
		{
			_appDbContext.Remove(entity);
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _appDbContext.Set<T>().ToListAsync();
		}

		public async Task<List<T>> GetbyFilter(Expression<Func<T, bool>> expression)
		{
			return await _appDbContext.Set<T>().Where(expression).ToListAsync();
		}

		public async Task<T> GetByIdAsync(string id)
		{
			return await _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
		}

		public void Update(T entity)
		{
			_appDbContext.Update(entity);
		}

		public async Task SaveChangesAsync()
		{
			await _appDbContext.SaveChangesAsync();
		}
	}
}
