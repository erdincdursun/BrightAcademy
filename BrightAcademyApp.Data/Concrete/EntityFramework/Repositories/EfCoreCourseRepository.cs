using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course>, ICourseRepository
    {
        public EfCoreCourseRepository(BrightAcademyAppDbContext _context) : base(_context)
        {
        }
        private BrightAcademyAppDbContext Context
        {
            get { return _dbContext as BrightAcademyAppDbContext; }
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var result = await Context
                .Courses
                .Where (c =>c.IsActive && c.Id == id)
                .Include(c=>c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                .Include(c => c.CourseTraniners)
                .ThenInclude(cc => cc.Trainer)
                .Include(c => c.CourseTraniees)
                .ThenInclude(cc => cc.Trainee)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Course>> GetCoursesFullDataAsync(bool? isActive = null)
        {
            var result = Context
                .Courses
                .AsQueryable();

            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(c => c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                .Include(c => c.CourseTraniners )
                .ThenInclude(cc => cc.Trainer)
                .Include(c => c.CourseTraniees)
                .ThenInclude(cc => cc.Trainee)   
                .AsQueryable();

            return await result.ToListAsync();
        }


    }
}
