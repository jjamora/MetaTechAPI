using Microsoft.AspNetCore.Mvc;
using MTC.Core.Mappers;
using MTC.Core.Models.DTO;
using MTC.Core.Services;

namespace MTC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _services;
        public CategoryController(IServiceManager services)
        {
            this._services = services ?? throw new ArgumentNullException(nameof(services));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            //get all categories
            var categories = await _services.CategoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet]
        [Route("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var category = await _services.CategoryService.GetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await CategoryMapper.DTOtoDomain(request);

            //create category
            await _services.CategoryService.Create(convertToModel!);
            return Ok(convertToModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDTO request)
        {
            //convert DTO to domain model
            var convertToModel = await CategoryMapper.DTOtoDomain(request);

            //update category
            await _services.CategoryService.Update(convertToModel!);
            return Ok(convertToModel);
        }
    }
}
