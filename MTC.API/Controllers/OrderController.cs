using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
using MTC.Core.Models;
using MTC.Core.Models.DTO;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _services;
        public OrderController(IServiceManager services)
        {
            this._services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            //get all orders
            var orders = await _services.OrderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet]
        [Route("GetOrderById")]
        public async Task<IActionResult> GetOrderById(string id)
        {
            var Order = await _services.OrderService.GetByIdAsync(id);
            return Ok(Order);
        }

        [HttpGet]
        [Route("GetAllPagingAsync")]
        public async Task<IActionResult> GetAllPagingAsync(PageParameter param)
        {
            var order = await _services.OrderService.GetAllPagingAsync(param);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await OrderMapper.DTOtoDomain(request);

            //create Order
            await _services.OrderService.Create(convertToModel!);
            return Ok(convertToModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(OrderDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await OrderMapper.DTOtoDomain(request);

            //update Order
            await _services.OrderService.Update(convertToModel!);
            return Ok(convertToModel);
        }
    }
}
