using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public interface IStudentRepository
    {
        Student GetStudent(int Id);
        IEnumerable<Student> GetAllStudent();
        Student Add(Student student);
        Student Update(Student student);
        Student Delete(int id);
        List<Student> GetStudentByTeacherId(int id);

    }
}
