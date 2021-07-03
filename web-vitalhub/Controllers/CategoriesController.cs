using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vitalhub.Services.ServiceContracts;

namespace Vitalhub.Web.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("categories")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var result = await _categoryService.GetCateoryAsync();
            return Ok(result);
        }

    }
}
