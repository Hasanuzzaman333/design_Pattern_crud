using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DemoContext _context;

        public StudentRepository(DemoContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAllStudent()
        {
            return _context.Students;
        }
        public List<Student> GetStudentByTeacherId(int id)
        {
            List<Student> l = new List<Student>();
            var teacherStudent = _context.TeacherStudents.Where(c => c.TeacherId == id);
            //var jsonResult = Student.Select(c =>
            //    new { c.Id, c.Name, c.EmailAddress });
            foreach (var item in teacherStudent)
            {
               l.Add(_context.Students.Where(x => x.Id == item.StudentId).FirstOrDefault());
            }

            return l;
        }
        
        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }

       
    }
}
