using AutoMapper;
using ProductApp.Aplication.DTO;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Product, ProductViewDTO>().ReverseMap();
		}
	}
}
