using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Shared.DataTransferObject
{
    public class CourseTraineeDto
    {
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public string TraineeId { get; set; }
        public TranieeDto Trainee { get; set; }
    }
}
