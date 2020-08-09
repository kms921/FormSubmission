using System;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;


namespace FormSubmission.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index() //When in doubt, use IActionResult
        {
            return View("Index"); //or whatever you want to return
        }

        [HttpPost("")]
        public ViewResult Create(User FromForm) //When in doubt, use IActionResult
        {
            if (ModelState.IsValid) 
            {
                return View("Result", FromForm);  
            }
            else
            {
                return Index();
            }
        }
    }

}