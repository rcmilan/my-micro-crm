using MicroCRM.App.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace MicroCRM.App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CustomerViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Test",
            };

            return View(viewModel);
        }

        public IActionResult Detail()
        {
            var viewModel = new CustomerDataViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                BirthDate = DateOnly.FromDateTime(DateTime.Now)
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Post(CustomerDataViewModel viewModel)
        {
            return RedirectToAction(nameof(Detail));
        }
    }
}
