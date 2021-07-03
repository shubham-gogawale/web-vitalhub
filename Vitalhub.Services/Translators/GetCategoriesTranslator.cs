using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalhub.Services.Translators
{
    public static class GetCategoriesTranslator
    {
        public static GetCateoryResponse ToGetCategoryResponse(this List<Core.Category> categories)
        {
            return new GetCateoryResponse
            {
                Categories = categories.Select(x => x.ToModel()).ToList()
            };
        }
    }
}
