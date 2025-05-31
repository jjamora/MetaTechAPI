using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
using MTC.Core.Models;
using MTC.Core.Models.DTO;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaTypeController : ControllerBase
    {
        private readonly IServiceManager _services;
        public PizzaTypeController(IServiceManager services)
        {
            this._services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPizzaTypesAsync()
        {
            //get all pizza types
            var types = await _services.PizzaTypeService.GetAllAsync();
            return Ok(types);
        }

        [HttpGet]
        [Route("GetPizza_TypeById")]
        public async Task<IActionResult> GetPizza_TypeById(string id)
        {
            var type = await _services.PizzaTypeService.GetByIdAsync(id);
            return Ok(type);
        }

        [HttpGet]
        [Route("GetAllPagingAsync")]
        public async Task<IActionResult> GetAllPagingAsync(PageParameter param)
        {
            var types = await _services.PizzaTypeService.GetAllPagingAsync(param);
            return Ok(types);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePizza_Type(Pizza_TypeDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await PizzaTypeMapper.DTOtoDomain(request);

            //create Pizza_Type
            await _services.PizzaTypeService.Create(convertToModel!);
            return Ok(convertToModel);
        }
    }
}
