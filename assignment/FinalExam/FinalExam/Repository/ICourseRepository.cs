using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public interface ICourseRepository
    {
        Course GetStudent(int Id);
        IEnumerable<Course> GetAllCourses();
        Course Add(Course course);
        Course Update(Course course);
        Course Delete(int id);
        List<Course> GetCourseByStudentId(int id);
    }
}
