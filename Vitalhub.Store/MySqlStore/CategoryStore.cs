using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalhub.Core;

namespace Vitalhub.Store.MySqlStore
{
    public class CategoryStore : ICategoryStore
    {
        private CategoryContext _context;
        public CategoryStore(CategoryContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCateoryAsync()
        {
           return _context.Categories.ToList();
        }
    }
}
