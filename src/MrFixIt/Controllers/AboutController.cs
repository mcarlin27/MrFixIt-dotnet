using Microsoft.AspNetCore.Mvc;

namespace MrFixIt.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
