using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
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
            var Pizza = await _services.PizzaService.GetByIdAsync(id);
            return Ok(Pizza);
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
    }
}
