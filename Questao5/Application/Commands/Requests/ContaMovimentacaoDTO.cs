using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Questao5.Application.Commands.Requests
{
    public class ContaMovimentacaoDTO
    {
        public string RequisicaoId { get; set; }
        public string IdentificacaoContaId { get; set; }
        public decimal MovimentacaoValor { get; set; }
        public string TipoMovimento { get; set; }

    }
}
