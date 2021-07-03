using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalhub.Web.Contracts;

namespace Vitalhub.Web
{
    public static class GetCategoriesTranslator
    {
        public static GetCateoryResponse ToGetCategoryResponse(this List<Services.Category> categories)
        {
            return new GetCateoryResponse
            {
                Categories = categories.Select(x => x.ToModel()).ToList()
            };
        }
    }
}
