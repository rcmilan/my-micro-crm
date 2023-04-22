namespace MicroCRM.App.Models.Lead.Form
{
    // Não deve ser usado como model da tela
    // deve ser usado como POST da criação de form
    public class CreateFormViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<CreateFormFieldViewModel> Fields { get; set; }
    }
}
