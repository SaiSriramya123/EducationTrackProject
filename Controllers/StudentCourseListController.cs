using Microsoft.AspNetCore.Mvc;

namespace EducationTrackProject.Controllers
{
    public class StudentCourseListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
