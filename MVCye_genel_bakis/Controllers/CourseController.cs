using Microsoft.AspNetCore.Mvc;
using MVCye_genel_bakis.Models;

namespace MVCye_genel_bakis.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model){

            if(Repository.Applications.Any(c => c.Email.Equals(model.Email))){
                ModelState.AddModelError("","There is already an application for you.");
            }

            if(ModelState.IsValid){
                Repository.Add(model);
                return View("Feedback",model);
            }
            else{
                return View();
            }
        }
    }
}