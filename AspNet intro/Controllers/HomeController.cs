using Microsoft.AspNetCore.Mvc;

namespace AspNet_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int[] nums = {1,2,3,4,5,6};
            return View(nums);
            //return Json("Salamlar");
            //return Json(new {name="Anar",surname="Huseynov"});
            //return Ok("success");
            //return NotFound();
            //return BadRequest();
        }
    }
}
