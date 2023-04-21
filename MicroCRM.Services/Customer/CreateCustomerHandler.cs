using MediatR;
using MicroCRM.Services.Customer.Commands;

namespace MicroCRM.Services.Customer
{
    internal class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var res = new CreateCustomerResponse(Guid.NewGuid());

            return Task.FromResult(res);
        }
    }
}
