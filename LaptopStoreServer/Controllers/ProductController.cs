﻿using LaptopStoreSharedLibrary.Contracts;
using LaptopStoreSharedLibrary.Models;
using LaptopStoreSharedLibrary.Response;

using Microsoft.AspNetCore.Mvc;

namespace LaptopStoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProduct productService) : ControllerBase
    {
<<<<<<< HEAD
=======

>>>>>>> 24phut p3
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts(bool featured)
        {
            var products = await productService.GetAllProducts(featured); return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse>> AddProduct(Product model)
        {
            if(model is null) return BadRequest("Models is null!");
            var response = await productService.AddProDuct(model);
            return Ok(response);
        }
    }
}
