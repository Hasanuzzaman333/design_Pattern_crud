using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivaTest.Web.Entities
{
    public class StudentTeacher
    {
        public int StudentId { get; set; }
        public int TeacherID { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
