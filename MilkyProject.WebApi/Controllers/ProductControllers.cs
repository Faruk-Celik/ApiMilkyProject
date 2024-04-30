using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControllers : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductControllers ( IProductService productService )
        {
            _productService = productService;
        }
        [HttpGet]

        public IActionResult ProductList ()
        {
            var Values = _productService.TGetListAll();
            return Ok(Values);
        }
        [HttpPost]
        public IActionResult AddProduct ( Product product )
        {
            _productService.TInsert(product);
            return Ok("Product Inserted Successfully");
        }
        [HttpDelete]
        public IActionResult DeleteProduct ( int id )
        {
            _productService.TDelete(id);
            return Ok("Product Deleted Succesfully");
        }
        [HttpPut]
        public IActionResult UpdateProduct ( Product product )
        {
            _productService.TUpdate(product);
            return Ok("Product Updated Succesfully");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct ( int id )
        {
            var Values = _productService.TGetById(id);
            return Ok(Values);
        }
        [HttpGet("GetProductWithCategory")]
        public IActionResult GetProductWithCategory ()
        {
            var values = _productService.TGetProductsWithCategory();
            return Ok(values);
        }
    }
}
