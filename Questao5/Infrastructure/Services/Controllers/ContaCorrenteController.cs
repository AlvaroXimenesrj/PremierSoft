using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Application.Commands.Requests;
using Questao5.Application.Queries.Requests;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContaCorrenteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Consultar")]
        public async Task<IActionResult> Consultar(int contaId, CancellationToken cancellationToken)
        {
            var result =  await _mediator.Send(new ContaDetalhesQuery(contaId), cancellationToken);

            if (!result.isValid)
            {
                return BadRequest(result.retorno);
            }

            return Ok(result.retorno);
        }

        [HttpPost]
        [Route("Movimentar")]
        public async Task<IActionResult> Movimentar([FromBody] ContaMovimentacaoDTO command, CancellationToken cancellationToken)
        {
           var result =  await _mediator.Send(new ContaMovimentacaoCommand(command), cancellationToken);

            if (!result.isValid)
            {
                return BadRequest(result.retorno);
            }

            return Ok(result.retorno);
        }

        
    }
}
