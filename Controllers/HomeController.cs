using Microsoft.AspNetCore.Mvc;

namespace Portfolio_II.Controllers {
    public class HomeController : Controller {
        [HttpGet("")]
        public IActionResult Index(){
            return View("Index");
        }
    }

}