using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleData.Helper;
using SampleData.Models;
using SampleData.Services;
using SampleData.Core;
using Microsoft.AspNetCore.Authorization;

namespace SampleWeb.Areas.Student.Controllers
{
    [Area("Student")]
    public class StudentOperationController : Controller
    {
        private IStudentService _studentService;
        public StudentOperationController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent()
        {
            //throw new Exception("Error in add view");
            var studentModel = new StudentModel(_studentService);
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        //[Inject(usages: InjectionUsages.Fields)]
        public IActionResult AddStudent(StudentModel studentModel)
        {
            studentModel._studentService = this._studentService;
            studentModel.CreateStudent();
            return View();
        }
        [Authorize(Roles = "Admin,Manager")]
        public JsonResult GetStudent()        
        {
            var studentModel = new StudentModel(_studentService);
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var data = studentModel.GetStudents(tableModel);

            return Json(data);
        }

        [HttpGet]       
        public async Task<IActionResult> EditStudent(Guid id)
        {
            var studentModel = new StudentModel(_studentService);
            var student =  await studentModel.GetStudent(id);

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> EditStudent(SampleData.Core.Student student)
        {
            var studentModel = new StudentModel(_studentService);
            await studentModel.EditStudentAsync(student);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            var studentModel = new StudentModel(this._studentService);
            await studentModel.DeleteStudentAsync(id);

            return RedirectToAction("Index", "StudentOperation");
        }
    }
}