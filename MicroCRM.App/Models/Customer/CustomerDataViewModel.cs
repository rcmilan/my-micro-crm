using MicroCRM.Services.Customer.Commands;

namespace MicroCRM.App.Models.Customer
{
    public class CustomerDataViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public CreateCustomerCommand MapToCreateCustomerRequest() => new(Name);
    }
}
