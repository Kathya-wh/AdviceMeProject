using ASPNETPractice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETPractice1
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
