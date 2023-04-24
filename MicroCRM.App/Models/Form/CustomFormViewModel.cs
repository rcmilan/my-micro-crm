namespace MicroCRM.App.Models.Form
{
    public class CustomFormViewModel
    {
        public Guid Id { get; set; }
        public IList<CustomFormInputViewModel> Inputs { get; set; } = default!;
        public string Title { get; set; } = default!;
    }
}