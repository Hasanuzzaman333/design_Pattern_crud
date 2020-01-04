using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FinalExam.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public StudentController(ICourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }
        public ActionResult Index()
        {
            //for short of time id is hard coded
            return View(_courseRepository.GetCourseByStudentId(Convert.ToInt32(1)));
        }
    }
}