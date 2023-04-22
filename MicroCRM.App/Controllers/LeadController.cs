using Microsoft.AspNetCore.Mvc;

namespace MicroCRM.App.Controllers
{
    public class LeadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View("./Form/index");
        }
    }
}
