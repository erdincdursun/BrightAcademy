using BrightAcademyApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Configs
{
    public class CourseTrainerConfig : IEntityTypeConfiguration<CourseTrainer>
    {
        public void Configure(EntityTypeBuilder<CourseTrainer> builder)
        {
            builder.HasKey(ct => new { ct.CourseId, ct.TrainerId });
            builder.HasData(
                new CourseTrainer { CourseId = 1, TrainerId = "5" },
                new CourseTrainer { CourseId = 2, TrainerId = "6" },
                new CourseTrainer { CourseId = 3, TrainerId = "5" },
                new CourseTrainer { CourseId = 4, TrainerId = "6" },

                new CourseTrainer { CourseId = 5, TrainerId = "6" },
                new CourseTrainer { CourseId = 5, TrainerId = "5" },
                new CourseTrainer { CourseId = 6, TrainerId = "6" },
                new CourseTrainer { CourseId = 7, TrainerId = "5" }


           );
        }
    }
}
