﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Entity.Concrete
{
    public class CourseTrainer
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
