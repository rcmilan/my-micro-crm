using MicroCRM.App.Models.Lead.Form;
using Microsoft.AspNetCore.Mvc;

namespace MicroCRM.App.Controllers
{
    public class LeadController : Controller
    {
        // db
        private static readonly IList<FormListViewModel> createFormViewModels = new List<FormListViewModel>
        {
            new FormListViewModel(Guid.NewGuid(), "Form teste")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View("./Form/Index", createFormViewModels);
        }

        public IActionResult FormDetail(CreateOrEditFormViewModel viewModel)
        {
            return View("./Form/Detail", viewModel);
        }

        [HttpPost]
        public IActionResult CreateForm([FromBody] CreateOrEditFormViewModel viewModel)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}