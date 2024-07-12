using Microsoft.AspNetCore.Mvc;

namespace BozMetal.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
