﻿namespace MicroCRM.App.Models.Form
{
    public record CreateOrEditFormViewModel(Guid Id, string Name)
    {
        public IList<CreateFormFieldViewModel> Fields { get; set; } = default!;
    }
}