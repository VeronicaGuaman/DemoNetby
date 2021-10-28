using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}
