using EshopApplication.Interfaces;
using EshopApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : Controller
    {
        private readonly ICarts _Icarts;
        public CartsController(ICarts Icarts)
        {
            _Icarts = Icarts;
        }
        [HttpPost]
        [Route("AddProductsToCart")]
        public IActionResult AddProductsToCart(Carts items)
        {
            _Icarts.addProductsToCart(items);
            return Created("/"+items.Id,items);
        }

        [HttpDelete]
        [Route("DeleteProductbyCartId{id}")]
        public IActionResult Delete(int id)
        {
            var cartid = _Icarts.GetProduct(id);
            if (cartid != null)
            {
                _Icarts.DeleteProduct(cartid);
                return Ok();
            }
            return NotFound($"Not found with {id}");

        }

        //for sp
        [HttpGet]
        [Route("GetProductsFromCartbyUser{id}")]
        public IActionResult GetProduct(int id)
        {
            /*SqlParameter userId = new SqlParameter("@UserId", id);*/
            var usersList = _Icarts.GetAllProducts(id);
            return Ok(usersList);
        }

        [HttpDelete]
        [Route("BulkDeletebyUser{userId}")]
        public IActionResult BulkDeletebyUser(int userId)
        {
            _Icarts.BulkDeleteItemsbyUserId(userId);
            return Ok();
        }
    }
}
