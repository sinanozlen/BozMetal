using Microsoft.AspNetCore.Mvc;

namespace BozMetal.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
