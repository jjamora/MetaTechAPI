using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
using MTC.Core.Models;
using MTC.Core.Models.DTO;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IServiceManager _services;
        public PizzaController(IServiceManager services)
        {
            this._services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPizzasAsync()
        {
            //get all pizzas
            var pizzas = await _services.PizzaService.GetAllAsync();
            return Ok(pizzas);
        }

        [HttpGet]
        [Route("GetPizzaById")]
        public async Task<IActionResult> GetPizzaById(string id)
        {
            var pizza = await _services.PizzaService.GetByIdAsync(id);
            return Ok(pizza);
        }

        [HttpGet]
        [Route("GetAllPagingAsync")]
        public async Task<IActionResult> GetAllPagingAsync(PageParameter param)
        {
            var pizzas = await _services.PizzaService.GetAllPagingAsync(param);
            return Ok(pizzas);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePizza(PizzaDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await PizzaMapper.DTOtoDomain(request);

            //create Pizza
            await _services.PizzaService.Create(convertToModel!);
            return Ok(convertToModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePizza(PizzaDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await PizzaMapper.DTOtoDomain(request);

            //update Pizza
            await _services.PizzaService.Update(convertToModel!);
            return Ok(convertToModel);
        }
    }
}
