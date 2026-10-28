using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Project.Areas.Admin.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
