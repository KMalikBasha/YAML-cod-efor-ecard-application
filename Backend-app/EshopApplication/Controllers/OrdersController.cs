using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrders IOrders;
        public OrdersController(IOrders orders)
        {
            this.IOrders = orders;
        }
        [HttpGet]
        [Route("getListOfOrders")]
        public IActionResult getListOfOrders()
        {
            var result = IOrders.ListOfOrders();
            return Ok(result);
        }

        [HttpPost]
        [Route("addProducts")]
        public IActionResult addProducts(Orders orders)
        {
            this.IOrders.AddingProducts(orders);
            return Created("/" + orders.OrderId, orders);
        }
        [HttpPost]
        [Route("bulkAdd")]
        public IActionResult bulkAdd(List<Orders> orders)
        {
            foreach(var order in orders)
            {
                this.IOrders.AddingProducts(order);
            }
            return Ok();
        }

        [HttpGet]
        [Route("ordersbyUser{id}")]
        public IActionResult ordersbyUser(int id)
        {
            var result = this.IOrders.getUserOrderProducts(id);
            return Ok(result);
        }
    }
}
