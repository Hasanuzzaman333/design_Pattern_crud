using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Repository
{
    public interface ITeacherRepository
    {
        Teacher GetTeacher(int Id);
        IEnumerable<Teacher> GetAllTeachers();
        Teacher Add(Teacher teacher);
        Teacher Update(Teacher teacher);
        Teacher Delete(int id);
    }
}
