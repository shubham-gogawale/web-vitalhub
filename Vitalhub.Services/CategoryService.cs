using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalhub.Core;
using Vitalhub.Services.ServiceContracts;
using Vitalhub.Services.Translators;

namespace Vitalhub.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryStore _store;

        public CategoryService(ICategoryStore store)
        {
            _store = store;
        }
        public async Task<GetCateoryResponse> GetCateoryAsync()
        {
            var result = await _store.GetCateoryAsync();
            return result.ToGetCategoryResponse();
        }
    }
}
