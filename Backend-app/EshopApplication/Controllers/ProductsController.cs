using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProducts _IProducts;
        public ProductsController(IProducts products)
        {
            _IProducts = products;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            var result = _IProducts.GetProducts();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProducts")]
        public IActionResult AddProducts(Products products)
        {
            _IProducts.AddProducts(products);
            return Created("/" + products.Id, products);
        }

        [HttpGet]
        [Route("GetProductsByCategoryId{id}")]
        public IActionResult GetProductsByCategoryId(int id)
        {
            var productList = _IProducts.GetProductsByCategory(id);
            return Ok(productList);
        }

        [HttpGet]
        [Route("GetProductById{id}")]
        public IActionResult GetProductById(int id)
        {
            var result = _IProducts.GetProductById(id);
            return Ok(result);
        }
    }
}
