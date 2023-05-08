using System.Runtime;
using MediatR;
using shop.Domain.Command.Response;

namespace shop.Domain.Command.Resquest
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}