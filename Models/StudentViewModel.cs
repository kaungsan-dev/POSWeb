using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }


        public List<StudentCourseViewModel> CourseList { get; set; }
    }
}
