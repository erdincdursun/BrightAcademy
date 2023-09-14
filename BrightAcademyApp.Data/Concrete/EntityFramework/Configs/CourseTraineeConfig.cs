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
    public class CourseTraineeConfig : IEntityTypeConfiguration<CourseTrainee>
    {
        public void Configure(EntityTypeBuilder<CourseTrainee> builder)
        {
            builder.HasKey(ct => new { ct.CourseId, ct.TraineeId });
            builder.HasData(
               new CourseTrainee { CourseId = 1, TraineeId= "1"},
               new CourseTrainee { CourseId = 1, TraineeId = "2" },
               new CourseTrainee { CourseId = 1, TraineeId = "3" },
               new CourseTrainee { CourseId = 1, TraineeId = "4" },

               new CourseTrainee { CourseId = 2, TraineeId = "1" },
               new CourseTrainee { CourseId = 2, TraineeId = "3" },


               new CourseTrainee { CourseId = 3, TraineeId = "2" },
               new CourseTrainee { CourseId = 3, TraineeId = "4" },


               new CourseTrainee { CourseId = 4, TraineeId = "1" },
               new CourseTrainee { CourseId = 2, TraineeId = "4" },


               new CourseTrainee { CourseId = 5, TraineeId = "3" },

               new CourseTrainee { CourseId = 6, TraineeId = "3" },

               new CourseTrainee { CourseId = 7, TraineeId = "3" }
             






           );
        }
    }
}
