using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalhub.Services.Translators
{
    public static class CategoryTranslator
    {
        public static Category ToModel(this Core.Category category)
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
