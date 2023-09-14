using BrightAcademyApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Configs
{
    public class CourseCategoryConfig : IEntityTypeConfiguration<CourseCategory>

    {

        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.HasKey(cc => new { cc.CourseId, cc.CategoryId });
            builder.HasData(
                new CourseCategory { CategoryId = 1, CourseId = 1 },
                new CourseCategory { CategoryId = 1, CourseId = 2 },
                new CourseCategory { CategoryId = 1, CourseId = 3 },

                new CourseCategory { CategoryId = 2, CourseId = 4 },
                new CourseCategory { CategoryId = 2, CourseId = 5 },

                new CourseCategory { CategoryId = 3, CourseId = 6 },
                new CourseCategory { CategoryId = 4, CourseId = 7 },

                new CourseCategory { CategoryId = 5, CourseId = 8 },
                new CourseCategory { CategoryId = 5, CourseId = 9 },

                new CourseCategory { CategoryId = 6, CourseId = 2 },
                new CourseCategory { CategoryId = 6, CourseId = 3 }

                );
        }
    }
}
