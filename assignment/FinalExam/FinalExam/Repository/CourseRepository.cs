using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DemoContext _context;

        public CourseRepository(DemoContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses;

        }
        public List<Course> GetCourseByStudentId(int id)
        {
            List<Course> l = new List<Course>();
            var StudentCourse = _context.StudentCourses.Where(c => c.StudentId == id);
            foreach (var item in StudentCourse)
            {
                l.Add(_context.Courses.Where(x => x.Id == item.CourseId).FirstOrDefault());
            }

            return l;
        }


        public Course Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Course Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public Course Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
