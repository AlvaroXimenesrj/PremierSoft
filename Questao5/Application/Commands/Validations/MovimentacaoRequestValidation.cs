using Questao5.Application.Commands.Requests;

namespace Questao5.Application.Commands.Validations
{
    public class MovimentacaoRequestValidation : CommandValidation<ContaMovimentacaoCommand>
    {
        public MovimentacaoRequestValidation(string tipoMovimentacao)
        {
            ValidateContaMovimentacao(tipoMovimentacao);
        }
    }
}
