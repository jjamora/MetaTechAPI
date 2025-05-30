using Microsoft.AspNetCore.Mvc;
using MTC.Core.Models;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager services;
        public CategoryController(IServiceManager services)
        {
            this.services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            //get all categories
            var categories = await services.CategoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDTO request)
        {
            //convert DTO to domain model
            var convertToModel = new Category
            {
                Id = string.IsNullOrEmpty(request.Id) ? Guid.NewGuid().ToString() : request.Id,
                Name = request.Name
            };

            await services.CategoryService.Create(convertToModel);
            return Ok(convertToModel);
        }
    }
}
