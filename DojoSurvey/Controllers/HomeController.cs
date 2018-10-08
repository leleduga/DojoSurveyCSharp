using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoSurvey.Models;



namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
       [Route("")]
        public IActionResult Index()
        {
        return View();
        }

 
// In HomeController
        [HttpPost("SurveyViewModel/create")]
        public IActionResult Method(SurveyViewModel surveyViewModel)
        {
            if(ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success",surveyViewModel);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
                [HttpGet]
                [Route("success")]
                public IActionResult Success()
                {

                    return View();
                }


                public IActionResult Error()
                {
                    return View();
                }
            }
        }



