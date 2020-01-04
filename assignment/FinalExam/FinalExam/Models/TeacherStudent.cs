using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    public class TeacherStudent
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
