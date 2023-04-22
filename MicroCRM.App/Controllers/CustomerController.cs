using MediatR;
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
                CreatedAt = DateTime.Now
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IMediator mediator, CustomerDataViewModel viewModel)
        {
            var req = viewModel.MapToCreateCustomerRequest();

            var res = await mediator.Send(req);

            // deve retornar 200
            return RedirectToAction(nameof(Detail), new { res.Id });
        }
    }
}