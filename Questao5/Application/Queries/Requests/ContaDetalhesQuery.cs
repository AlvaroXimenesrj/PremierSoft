using MediatR;
using Questao5.Application.Commands.Requests;
using Questao5.Application.Commands.Validations;
using Questao5.Application.Core;
using Questao5.Application.Queries.Responses;

namespace Questao5.Application.Queries.Requests
{   
    public class ContaDetalhesQuery : Command, IRequest<(object retorno, bool isValid)>
    {
        public ContaDetalhesQuery(int contaId)
        {
            ContaId = contaId;
        }

        public int ContaId { get; set; }

    }
}
