using Microsoft.AspNetCore.Mvc;
using MVCye_genel_bakis.Models;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model){
            return View();
        }
    }
}