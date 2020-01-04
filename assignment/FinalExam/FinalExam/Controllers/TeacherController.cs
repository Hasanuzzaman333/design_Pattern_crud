using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        private readonly IStudentRepository _StudentRepository;
        public TeacherController(IStudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }
        public ActionResult Index()
        {
            //string sessionID = HttpContext.Session.Id;
            //for short of time id is hard coded
            return View(_StudentRepository.GetStudentByTeacherId(Convert.ToInt32(1)));
        }
    }
}