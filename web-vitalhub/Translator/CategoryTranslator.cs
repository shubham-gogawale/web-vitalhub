using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalhub.Web
{
    public static class CategoryTranslator
    {
        public static Category ToModel(this Services.Category category)
        {
            return new Category
            {
                Id = category.Id,
                HeroImageUrl = category.HeroImageUrl,
                Name = category.Name
            };
        }

    }
}
