using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Business.Concrete;
using BrightAcademyApp.Shared.ControllerBases;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BrightAcademyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomControllerBase
    {
        private readonly ICourseService _courseManager;

        public CoursesController(ICourseService courseManager)
        {
            _courseManager = courseManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            var response = await _courseManager.GetCoursesFullDataAsync(true); 
            return CreateActionResult(response);
          
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var response = await _courseManager.GetCourseByIdAsync(id);
            return CreateActionResult(response);

        }
        [HttpPost]
        [Route("/api/[controller]/CreateCourse")]
        public async Task<IActionResult> SaveBook(CourseCreateDto courseCreateDto)
        {
            var response = await _courseManager.CreateAsync(courseCreateDto);
            return CreateActionResult(response);
        }
    }
}
