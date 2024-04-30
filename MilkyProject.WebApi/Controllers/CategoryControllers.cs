using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControllers : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryControllers ( ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var Values = _categoryService.TGetListAll(); 
            return Ok(Values);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return Ok("Category Inserted Successfully");
        }
        [HttpDelete]
        public IActionResult DeleteCategory (int id)
        {
            _categoryService.TDelete(id);
            return Ok("Category Deleted Succesfully");
        }
        [HttpPut]
        public IActionResult UpdateCategory ( Category category )
        {
            _categoryService.TUpdate(category);
            return Ok("Category Updated Succesfully");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory (int id)
        {
            var Values = _categoryService.TGetById(id);
            return Ok(Values);
        }

    }
}
