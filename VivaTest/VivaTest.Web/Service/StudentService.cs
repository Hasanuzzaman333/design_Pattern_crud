using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Core.UOW;
using VivaTest.Web.Entities;

namespace VivaTest.Web.Service
{
    public class StudentService : IStudentService
    {
        private readonly UnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }
        public void CreateStudent(Student student)
        {
            _unitOfWork.StudentRepository.Add(student);
            _unitOfWork.Save();
        }

        public void DeleteStudent(Student student)
        {
            _unitOfWork.StudentRepository.Remove(student);
            _unitOfWork.Save();
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(Student student)
        {
            _unitOfWork.StudentRepository.Update(student);
            _unitOfWork.Save();
        }

        public Task EditStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _unitOfWork.StudentRepository.GetAll();
        }

        public Student GetStudent(int id)
        {
            return _unitOfWork.StudentRepository.GetById(id);
        }
    }
}
