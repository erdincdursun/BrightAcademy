using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(BrightAcademyAppDbContext _context) : base(_context)
        {
        }
    }
}
