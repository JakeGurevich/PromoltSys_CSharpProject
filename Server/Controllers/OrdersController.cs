using Microsoft.AspNetCore.Mvc;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {


        IOrderServices _orderServices;
        public OrdersController(IOrderServices OrderServices)
        {
            _orderServices = OrderServices;
        }
       
        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult<List<OrderModel>>> Get()
        {
            var orders = await _orderServices.GetOrders();
            return orders;
        }

        [HttpGet("filter/{id}")]
        public async Task<ActionResult<List<OrderModel>>> GetOrders(string id)
        {
            var orders = await _orderServices.GetOrders(id);
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderModel>> Get(string id)
        {
            var order = await _orderServices.GetOrder(id);

            if (order is null)
            {
                return NotFound();
            }

            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderModel newOrder)
        {
            await _orderServices.CreateOrder(newOrder);

            return CreatedAtAction(nameof(Get), new { id = newOrder.Id }, newOrder);


        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
