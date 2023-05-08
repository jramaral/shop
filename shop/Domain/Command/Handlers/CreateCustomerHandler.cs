using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using shop.Domain.Command.Response;
using shop.Domain.Command.Resquest;

namespace shop.Domain.Command.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //verifica se o cliente já está cadastrado
            //valida os dados
            //insere o cliente
            //envia email de boa vindas

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Jose Roberto",
                Email = "jose@jramaral.dev",
                Date = DateTime.Now

            };

            return Task.FromResult(result);
        }
    }
}