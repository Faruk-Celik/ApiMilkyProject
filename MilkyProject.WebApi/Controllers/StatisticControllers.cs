using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticControllers : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public StatisticControllers ( ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryCount ()
        {
            var values = _categoryService.TGetCategoryCount();
            return Ok(values);
        }
    }
}
