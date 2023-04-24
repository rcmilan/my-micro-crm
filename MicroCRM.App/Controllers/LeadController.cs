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

        [Obsolete("mover para form controller")]
        public IActionResult Form()
        {
            return View("../Form/Index", createFormViewModels);
        }

        [Obsolete("mover para form controller")]
        public IActionResult FormDetail(CreateOrEditFormViewModel viewModel)
        {
            return View("../Form/Detail", viewModel);
        }
    }
}