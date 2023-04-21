using MediatR;

namespace MicroCRM.Services.Customer.Commands
{
    public record CreateCustomerCommand(string Name) : IRequest<CreateCustomerResponse>;
}