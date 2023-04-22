using MicroCRM.App.Models.Lead.Form;
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
            var m = new CreateFormViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Form 123",
            };

            return View("./Form/index", m);
        }

        [HttpPost]
        public IActionResult CreateForm([FromBody] CreateFormViewModel viewModel)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}