using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Abstract
{
    public interface ICourseService
    {
        Task<Response<CourseDto>> GetByIdAsync(int? id);
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Response<NoContent> Update(CourseDto courseDto);
        Task<Response<NoContent>> Delete(int id);


        Task<Response<List<CourseDto>>> GetCoursesFullDataAsync(bool? isActive = null);
        Task<Response<CourseDto>> GetCourseByIdAsync(int id);
    }
}
