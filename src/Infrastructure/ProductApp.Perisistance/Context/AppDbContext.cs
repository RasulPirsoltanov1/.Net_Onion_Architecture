using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Perisistance.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Product>? Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					CreateDate = DateTime.Now,
					Id = Guid.NewGuid(),
					Name = "pen",
					Quantity = 12,
					Value = 0.2m
				},
					new Product
					{
						CreateDate = DateTime.Now,
						Id = Guid.NewGuid(),
						Name = "Phone",
						Quantity = 12,
						Value = 1233m
					},
						new Product
						{
							CreateDate = DateTime.Now,
							Id = Guid.NewGuid(),
							Name = "Book",
							Quantity = 12,
							Value = 43
						},
							new Product
							{
								CreateDate = DateTime.Now,
								Id = Guid.NewGuid(),
								Name = "Car",
								Quantity = 12,
								Value = 12344
							}
			); ;
		}
	}
}
