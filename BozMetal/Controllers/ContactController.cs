using Microsoft.AspNetCore.Mvc;

namespace BozMetal.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
