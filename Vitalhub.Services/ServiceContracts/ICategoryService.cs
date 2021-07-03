using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalhub.Services.ServiceContracts
{
    public interface ICategoryService
    {
        Task<GetCateoryResponse> GetCateoryAsync();
    }
}
