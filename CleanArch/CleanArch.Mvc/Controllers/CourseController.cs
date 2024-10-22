using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{

    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService coruseService) { 
           _courseService = coruseService;
        }

        public IActionResult Index()
        {
            var model=_courseService.GetCourses();
            return View(model);
        }
    }
}
