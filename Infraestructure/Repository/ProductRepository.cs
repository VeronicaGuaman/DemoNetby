using Domain.Entities;
using Infraestructure.Data;
using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DemoContext context) :base(context)
        {
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }
    }
}
