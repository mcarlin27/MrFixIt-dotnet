using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MrFixIt.Models;

namespace MrFixIt.Controllers
{
    public class HomeController : Controller
    {
        private MrFixItContext db = new MrFixItContext();

        public IActionResult Index()
        {
            //if condition determines if user is authenticated and passes user's worker profile into model
            if (User.Identity.IsAuthenticated)
            {
                Worker thisWorker = db.Workers.FirstOrDefault(w => w.UserName == User.Identity.Name);
                return View(thisWorker);
                //changed 'var' and 'item' syntax to 'Worker' and 'w' for improved clarity
            }
            else
            {
                return View();
            }
        }
    }
}
