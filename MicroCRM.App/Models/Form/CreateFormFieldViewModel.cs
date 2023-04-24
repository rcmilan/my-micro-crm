using MicroCRM.Domain.Enums;

namespace MicroCRM.App.Models.Form
{
    public record CreateFormFieldViewModel(Guid Id, string Label, string InternalName, CustomFormInputType InputType = CustomFormInputType.Text);
}