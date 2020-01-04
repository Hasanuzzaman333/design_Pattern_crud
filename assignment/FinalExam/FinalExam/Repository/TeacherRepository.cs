using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DemoContext _context;

        public TeacherRepository(DemoContext context)
        {
            _context = context;
        }
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers;
        }
        public Teacher Add(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacher(int Id)
        {
            throw new NotImplementedException();
        }

        public Teacher Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
