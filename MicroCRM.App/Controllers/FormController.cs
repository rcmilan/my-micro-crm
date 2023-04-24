using MicroCRM.App.Models.Form;
using Microsoft.AspNetCore.Mvc;

namespace MicroCRM.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {

        [HttpPost]
        public IActionResult CreateForm([FromBody] CreateOrEditFormViewModel viewModel)
        {
            return Ok(viewModel.Id);
        }
    }
}
