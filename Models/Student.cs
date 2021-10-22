using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
