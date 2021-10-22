using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class StudentCourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsChecked { get; set; }
    }
}
