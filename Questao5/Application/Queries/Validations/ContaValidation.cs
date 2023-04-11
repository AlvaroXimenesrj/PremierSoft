using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Questao5.Application.Commands.Requests;
using Questao5.Application.Queries.Responses;


namespace Questao5.Application.Queries.Validations
{
    public abstract class ContaValidation<T> : AbstractValidator<T> where T : ContaDetalheDTO
    {
        public ValidationResult ValidationResult { get; set; }

        protected ContaValidation()
        {

            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidateMovimento()
        {            
            RuleFor(c => c.Ativo)
                .Custom((value, context) =>
                {
                    if (value == false)
                    {
                        context.AddFailure("A conta precisa estar ativa.");
                    }
                });

            return ValidationResult;
        }
    }
}
