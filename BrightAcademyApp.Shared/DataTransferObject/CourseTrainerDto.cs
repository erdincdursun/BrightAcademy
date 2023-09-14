using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Shared.DataTransferObject
{
    public class CourseTrainerDto
    {
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public string TrainerId { get; set; }
        public TranierDto Trainer { get; set; }
    }
}
