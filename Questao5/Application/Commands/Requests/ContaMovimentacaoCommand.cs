using MediatR;
using Questao5.Application.Commands.Validations;
using Questao5.Application.Core;

namespace Questao5.Application.Commands.Requests
{
    public class ContaMovimentacaoCommand : Command, IRequest<(object retorno, bool isValid)>
    {
        public ContaMovimentacaoCommand(ContaMovimentacaoDTO movimentacao)
        {
            Movimentacao = movimentacao;
        }

        public ContaMovimentacaoDTO Movimentacao { get; set; }        

        public bool ValidateRequisicaoMovimentacao()
        {
            ValidationResult = new MovimentacaoRequestValidation(Movimentacao.TipoMovimento).Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
