using Microsoft.AspNetCore.Mvc;

namespace Lab02_205051924_LeTrungHIeu.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
