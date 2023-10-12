using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Shared.ControllerBases;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BrightAcademyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        #region GetAll
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var response = await _categoryManager.GetAllAsync();
            if (!response.IsSucceeded)
            {
                return NotFound();
            }
            var jsonResult = JsonSerializer.Serialize(response);
            return Ok(jsonResult);
        }
        #endregion
        #region GetId
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var jsonResult = JsonSerializer.Serialize(response);
            return Ok(jsonResult);
        }
        #endregion
        #region Create
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
        {
            var response = await _categoryManager.CreateAsync(categoryCreateDto);
            return CreateActionResult(response);
        }
        #endregion
        #region Delete
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var response = await _categoryManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
        #endregion
        #region Update
        [HttpPut]
        public async Task<IActionResult> Update(int id, CategoryDto categoryDto)
        {
            _categoryManager.UpdateAsync(id, categoryDto);
            return NoContent(); //204
        }
        #endregion


    }
}
