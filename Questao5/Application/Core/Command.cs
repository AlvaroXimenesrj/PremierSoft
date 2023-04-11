using FluentValidation.Results;

namespace Questao5.Application.Core
{
    public abstract class Command
    {
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            ValidationResult = new ValidationResult();
        }       
    }
}