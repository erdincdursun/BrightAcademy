using BrightAcademyApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Entity.Concrete
{
    public class Settings
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Contact { get; set; }
        public string Questions { get; set; }

    }
}

