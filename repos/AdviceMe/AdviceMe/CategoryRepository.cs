using AdviceMe.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _connection;
        public CategoryRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories;");
        }





    }
}
