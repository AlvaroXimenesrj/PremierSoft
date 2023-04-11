using Questao5.Application.Queries.Responses;

namespace Questao5.Application.Queries.Validations
{
    public class ContaBussinnnesRulesValidation : ContaValidation<ContaDetalheDTO>
    {
        public ContaBussinnnesRulesValidation()
        {
            ValidateMovimento();
        }
    }
}
