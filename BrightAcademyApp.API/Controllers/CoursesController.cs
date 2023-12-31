﻿using BrightAcademyApp.Business.Abstract;
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

        #region GetAll
        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            var response = await _courseManager.GetCoursesFullDataAsync(true);

            return Ok(response);

        }
        #endregion
        #region GetId
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var response = await _courseManager.GetCourseByIdAsync(id);
            return Ok(response);

        }
        #endregion
        #region Create
        [HttpPost]
        [Route("/api/[controller]/CreateCourse")]
        public async Task<IActionResult> CreateCourse(CourseCreateDto courseCreateDto)
        {
            var response = await _courseManager.CreateAsync(courseCreateDto);
            return CreateActionResult(response);
        }
        #endregion
        #region Delete
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var response = await _courseManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
        #endregion
        #region Update
        [HttpPut]
        public async Task<IActionResult> UpdateCourse(int id, CourseDto courseDto)
        {
            _courseManager.UpdateAsync(id, courseDto);
            return NoContent(); //204
        }
        #endregion

    }
}
