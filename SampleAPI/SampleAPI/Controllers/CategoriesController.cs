using Microsoft.AspNetCore.Mvc;
using SampleBLL.Interfaces;
using SampleDAL.DbModels;
using SampleDAL.Repository;
using SampleDAL.ViewModels;
using AutoMapper;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : BaseApiController<CategoriesController>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ILogger<CategoriesController> logger, ICategoryService categoryService, IMapper mapper) 
            : base(logger)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VMCategory>>> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<VMCategory>> CreateCategory(VMCategory vmCategory)
        {
            // Map CategoryViewModel to Category
            var category = _mapper.Map<Category>(vmCategory);
            var createdCategory = await _categoryService.AddAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = createdCategory.CategoryId }, createdCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, VMCategory vmCategory)
        {
            // Map CategoryViewModel to Category
            var category = _mapper.Map<Category>(vmCategory);

            await _categoryService.UpdateAsync(category);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _categoryService.Remove(category);

            return NoContent();
        }
    }
}
