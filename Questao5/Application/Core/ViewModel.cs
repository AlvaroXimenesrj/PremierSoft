using FluentValidation.Results;

namespace Questao5.Application.Core
{
    public abstract class ViewModel
    {
        public ValidationResult ValidationResult { get; set; }

        protected ViewModel()
        {
            ValidationResult = new ValidationResult();
        }
    }
}
