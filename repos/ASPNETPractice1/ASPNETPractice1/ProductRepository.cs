using ASPNETPractice1.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace ASPNETPractice1
{
    public class ProductRepository : IProductRepository//connection
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection) 
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()//implementation
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
