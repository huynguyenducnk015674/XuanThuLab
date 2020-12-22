using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _07.EF01.Models
{
    
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }

        public Grade Grade { get; set; }
        public StudentAddress Address { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
