using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VivaTest.Web.Core.UOW;
using VivaTest.Web.Entities;
using VivaTest.Web.Service;

namespace VivaTest.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService as StudentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudent();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            return View(_studentService.GetStudent(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_studentService.GetStudent(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            _studentService.DeleteStudent(_studentService.GetStudent(id));
            return RedirectToAction("Index", "Student");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost(Student student)
        {
            _studentService.CreateStudent(student);
            return RedirectToAction("Index", "Student");
        }
        public IActionResult Edit(int id)
        {
            return View(_studentService.GetStudent(id));
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost(Student student)
        {
            _studentService.EditStudent(student);
            return RedirectToAction("Index", "Student");
        }
    }
}