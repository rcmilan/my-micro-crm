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
    }
}
