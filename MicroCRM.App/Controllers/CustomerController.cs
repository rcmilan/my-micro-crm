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
                Customers = new List<CustomerListViewModel>
                {
                    new CustomerListViewModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "Name",
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult Detail(Guid id)
        {
            var viewModel = new CustomerDataViewModel
            {
                Id = id,
                Name = "Test",
                BirthDate = DateOnly.FromDateTime(DateTime.Now)
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Post(CustomerDataViewModel viewModel)
        {
            return RedirectToAction(nameof(Detail), new { viewModel.Id });
        }
    }
}
