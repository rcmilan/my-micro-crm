using MicroCRM.Domain.Enums;

namespace MicroCRM.App.Models.Form
{
    public class CustomFormInputViewModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public CustomFormInputType InputType { get; set; }
    }
}
