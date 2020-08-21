using AdviceMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
    }
}
