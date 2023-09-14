using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Abstract
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<List<Course>> GetCoursesFullDataAsync(bool? isActive = null);
        Task<Course> GetCourseByIdAsync(int id);


    }
}
