﻿using Domain.Entities;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(DemoContext context) :base(context)
        {
        }
    }
}
