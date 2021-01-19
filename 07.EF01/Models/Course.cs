using System.Collections.Generic;

namespace _07.EF01.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
