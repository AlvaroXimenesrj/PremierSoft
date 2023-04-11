using MediatR;
using Questao5.Application.Queries.Requests;
using Questao5.Infrastructure.Database.QueryStore.Requests;
using Questao5.Infrastructure.Database.QueryStore.Responses;

namespace Questao5.Application.Handlers
{
    public class ContaDetalhesQueryHandler : IRequestHandler<ContaDetalhesQuery, (object retorno, bool isValid)>
    {        
        private IContaReadRepository _contaReadRepository;        

        public ContaDetalhesQueryHandler(IContaReadRepository contaReadRepository)
        {     
            _contaReadRepository = contaReadRepository;            
        }

        public async Task<(object retorno, bool isValid)> Handle(ContaDetalhesQuery request, CancellationToken cancellationToken)
        {
            var conta = await _contaReadRepository.GetContabyId(request.ContaId);

            if(conta == null)
            {

                return (new { Error = "INVALID_ACCOUNT" }, false);
            }

            if (conta.Ativo == false)
            {

                return (new { Error = "INACTIVE_ACCOUNT" }, false);
            }

            var contaQueryResult = new SaldoContaResponse(conta.Numero, conta.Nome, conta.GetSaldoDaConta());
            
            return (new { contaQueryResult }, true);
        }
    }
}