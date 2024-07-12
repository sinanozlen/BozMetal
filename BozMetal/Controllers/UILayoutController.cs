using Microsoft.AspNetCore.Mvc;

namespace BozMetal.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
