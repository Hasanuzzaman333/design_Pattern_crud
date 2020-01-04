using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SampleWeb.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger _logger;
        public ErrorController(ILogger<ErrorController> logger)
        {
            this._logger = logger;
        }


        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Requested Page Is Not Found";
                    //ViewBag.OrginalPath = statusCodeResult.OriginalPath;
                    //ViewBag.Qs = statusCodeResult.OriginalQueryString;
                    _logger.LogWarning($"404 error occured. Path = " +
                   $"{statusCodeResult.OriginalPath} and QueryString = " +
                   $"{statusCodeResult.OriginalQueryString}");

                    break;
            }


            return View("NotFound");
        }
        [Route("Exception")]
        public IActionResult Exception()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            //ViewBag.ExceptionPath = exceptionDetails.Path;
            //ViewBag.ExceptionMessage = exceptionDetails.Error.Message;
            //ViewBag.StackTrace = exceptionDetails.Error.StackTrace;

            _logger.LogError($"The Path {exceptionDetails.Path} threw an exception"
                +$"{exceptionDetails.Error}");
                                          
            return View("Exception");
        }
    }
}