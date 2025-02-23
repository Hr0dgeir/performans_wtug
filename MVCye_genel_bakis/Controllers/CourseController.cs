using Microsoft.AspNetCore.Mvc;

namespace MVCye_genel_bakis.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Apply(){
            return View();
        }
    }
}