using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Core
{
    public class StudentCourse
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
