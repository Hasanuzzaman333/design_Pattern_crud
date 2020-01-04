using SampleData.Core;
using SampleData.Helper;
using SampleData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Models
{
    public class StudentModel
    {
        //[FromDI]
        public IStudentService _studentService;
        public string StudentName { get; set; }
        public double StudentAge { get; set; }

        public StudentModel()
        {

        }
        public StudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void CreateStudent()
        {
            _studentService.CreateStudent(new Core.Student
            {
                StudentName = StudentName,
                Age = StudentAge
            });

        }

        public async Task<Student> GetStudent(Guid studentId)
        {
            var student = await _studentService.GetStudentAsync(studentId);

            return student;
        }

        public object GetStudents(DataTablesAjaxRequestModel tableModel)
        {
            var total = 0;
            var totalFiltered = 0;
            var records = _studentService.GetStudents(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                out total,
                out totalFiltered);

            return new
            {
                recordsTotal = total,
                recordsFiltered = totalFiltered,
                data = (from record in records
                        select new string[]
                        {
                                record.Id.ToString(),
                                record.StudentName,
                                record.Age.ToString()
                        }
                    ).ToArray()

            };
        }



        public async Task EditStudentAsync(Student student)
        {
            await _studentService.EditStudentAsync(student);
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            await _studentService.DeleteStudentAsync(id);
        }
    }
}
