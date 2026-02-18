using Microsoft.AspNetCore.Mvc;

namespace EducationTrackProject.Controllers
{
    public class StudentProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
