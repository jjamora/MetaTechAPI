﻿using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
using MTC.Core.Models.DTO;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order_DetailController : ControllerBase
    {
        private readonly IServiceManager _services;
        public Order_DetailController(IServiceManager services)
        {
            this._services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        [Route("GetAllOrderDetailsByIdAsync")]
        public async Task<IActionResult> GetAllOrderDetailsByIdAsync(string id)
        {
            //get all order details
            var details = await _services.Order_DetailService.GetAllByOrderIdAsync(id);
            return Ok(details);
        }

        [HttpGet]
        [Route("GetOrder_DetailById")]
        public async Task<IActionResult> GetOrder_DetailById(string id)
        {
            var detail = await _services.Order_DetailService.GetByIdAsync(id);
            return Ok(detail);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder_Detail(Order_DetailDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await Order_DetailMapper.DTOtoDomain(request);

            //create Order_Detail
            await _services.Order_DetailService.Create(convertToModel!);
            return Ok(convertToModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(Order_DetailDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await Order_DetailMapper.DTOtoDomain(request);

            //update OrderDetail
            await _services.Order_DetailService.Update(convertToModel!);
            return Ok(convertToModel);
        }
    }
}
