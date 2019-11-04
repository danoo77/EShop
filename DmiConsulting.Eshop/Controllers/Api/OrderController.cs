using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DmiConsulting.Eshop.Core.Exception;
using DmiConsulting.Eshop.Core.Services;
using DmiConsulting.Eshop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DmiConsulting.Eshop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }


        // GET: api/Order
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Order
        [HttpPost]
        public async Task<ActionResult<OrderItemViewModel>> Post([FromBody] OrderItemViewModel order)
        {
            try
            {
                await _orderService.OrderAsync(order.ProductId, order.Quantity);
                return Ok();
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(new ApiErrorViewModel((int) HttpStatusCode.InternalServerError,
                    HttpStatusCode.InternalServerError.ToString(), e.Message));
            }
            catch (ProductNotFountException e)
            {
                return NotFound(new ApiErrorViewModel((int) HttpStatusCode.NotFound, HttpStatusCode.NotFound.ToString(),
                    e.Message));
            }
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
