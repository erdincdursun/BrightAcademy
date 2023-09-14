using BrightAcademyApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Entity.Concrete
{
    public class Category : BaseEntity
    {
        public List<CourseCategory> CourseCategories { get; set; }

    }
}
