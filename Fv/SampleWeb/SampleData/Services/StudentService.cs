using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleData.Core;
using SampleData.UOW;

namespace SampleData.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentUnitOfWork _studentUnitOfWork;

        public StudentService(StudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork ?? throw new ArgumentNullException(nameof(studentUnitOfWork)); 
        }
        public void CreateStudent(Student student)
        {
            _studentUnitOfWork.Students.Add(student);
            _studentUnitOfWork.Save();
        }

        public void DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            await _studentUnitOfWork.Students.RemoveAsync(id);
            await _studentUnitOfWork.SaveAsync();
        }

        public void EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task EditStudentAsync(Student student)
        {
            await _studentUnitOfWork.Students.EditAsync(student);
            await _studentUnitOfWork.SaveAsync();            
        }

        public IEnumerable<Student> GetGroups(int pageIndex, int pageSize, string searchText, out int total, out int totalFiltered)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentAsync(Guid id)
        {
            return _studentUnitOfWork.Students.GetStudentAsync(id);
        }

        public IEnumerable<Student> GetStudents(int pageIndex, int pageSize, string searchText, out int total, out int totalFiltered)
        {
            total = 0;
            totalFiltered = 0;

            var studentsData = _studentUnitOfWork.Students.GetPaged(x => x.StudentName.Contains(searchText), y => y.OrderBy(z => z.Id), "", pageIndex, pageSize);
            total = studentsData.TotalDataCount;
            totalFiltered = studentsData.TotalDisplayableDataCount;

            return studentsData.Data;
        }
    }
}
