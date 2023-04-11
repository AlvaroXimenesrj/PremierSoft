using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components.Forms;
using Questao5.Application.Commands.Requests;

namespace Questao5.Application.Commands.Validations
{
    public abstract class CommandValidation<T> : AbstractValidator<T> where T : ContaMovimentacaoCommand
    {
        public ValidationResult ValidationResult { get; set; }

        protected CommandValidation()
        {

            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidateContaMovimentacao(string tipoMovimentacao)
        {
            RuleFor(c => c.Movimentacao.IdentificacaoContaId)            
                .NotEmpty().WithMessage("O Id da identificação da conta precisa ser informado");

            RuleFor(c => c.Movimentacao.MovimentacaoValor)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("É preciso informar um valor a ser movimentado")
                .GreaterThanOrEqualTo(0)
                .WithMessage("O valor da movimentação deve ser igual ou superior a zero");

            RuleFor(c => c.Movimentacao.RequisicaoId)            
                .NotEmpty().WithMessage("O Id da requisição precisa ser informado");

            RuleFor(c => c.Movimentacao.TipoMovimento)
                .Cascade(CascadeMode.Stop)
                .Custom((value, context) =>
                {
                    if (string.IsNullOrEmpty(tipoMovimentacao))
                    {
                        context.AddFailure("O tipo do movimento precisa ser informado");
                    }
                })
                .Custom((value, context) =>
                {
                    TipoMovimentoEnum newStatus;

                    if (!Enum.TryParse<TipoMovimentoEnum>(tipoMovimentacao, out newStatus))
                    {
                        context.AddFailure("O tipo do movimento precisa ser crédito ou débito");
                    }
                });

            return ValidationResult;
        }

    }
}
