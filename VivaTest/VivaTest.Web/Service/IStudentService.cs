using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Entities;

namespace VivaTest.Web.Service
{
    public interface IStudentService
    {
        void CreateStudent(Student student);
        void DeleteStudent(Student student);
        void EditStudent(Student student);
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudent();
        Task EditStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
