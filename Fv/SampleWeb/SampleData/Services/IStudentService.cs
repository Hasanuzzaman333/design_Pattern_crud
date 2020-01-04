using SampleData.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Services
{
    public interface IStudentService
    {
        void CreateStudent(Student student);
        void DeleteStudent(Student student);
        void EditStudent(Student student);
        Student GetStudent(Guid id);
        IEnumerable<Student> GetStudents(int pageIndex,int pageSize,string searchText,out int total,out int totalFiltered);
        Task<Student> GetStudentAsync(Guid id);
        Task EditStudentAsync(Student student);
        Task DeleteStudentAsync(Guid id);
        //Task<IEnumerable<Student>> GetStudents(int pageIndex, int pageSize, string searchText, out int total, out int totalFiltered);
    }
}
