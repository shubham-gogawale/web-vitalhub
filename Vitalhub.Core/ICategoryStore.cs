using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalhub.Core
{
    public interface ICategoryStore
    {

        Task<List<Category>> GetCateoryAsync();
    }
}
