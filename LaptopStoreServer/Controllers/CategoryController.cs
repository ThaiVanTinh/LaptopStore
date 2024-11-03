//using LaptopStoreSharedLibrary.Contracts;
using LaptopStoreSharedLibrary.Models;
using LaptopStoreSharedLibrary.Response;
using LaptopStoreServer.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace LaptopStoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategory categoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await categoryService.GetAllCategories(); return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse>> AddCategory(Category model)
        {
            if(model is null) return BadRequest("Models is null!");
            var response = await categoryService.AddCategory(model);
            return Ok(response);
        }
    }
}
