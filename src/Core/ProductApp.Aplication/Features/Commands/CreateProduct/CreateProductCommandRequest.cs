﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Commands.CreateProduct
{
	public class CreateProductCommandRequest:IRequest<Guid>
	{
        public string Name { get; set; }
		public decimal Value { get; set; }
		public int Quantity { get; set; }
	}
}
