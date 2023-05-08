using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using shop.Domain.Command.Handlers;
using shop.Domain.Command.Response;
using shop.Domain.Command.Resquest;

namespace shop.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices]IMediator mediator, [FromBody]CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
          
    }
}