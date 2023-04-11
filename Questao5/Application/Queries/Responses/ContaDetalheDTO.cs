using Questao5.Application.Core;

namespace Questao5.Application.Queries.Responses
{
    public class ContaDetalheDTO : ViewModel
    {
        public ContaDetalheDTO()
        {
            Movimentacoes = new List<MovimentacaoDto>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
        public List<MovimentacaoDto> Movimentacoes { get; set; }

        public decimal GetSaldoDaConta()
        {
            var creditos = Movimentacoes.Where(m => m.TipoMovimento == "credito").Select(m => m.Valor).Sum();
            var debitos = Movimentacoes.Where(m => m.TipoMovimento == "debito").Select(m => m.Valor).Sum();

            return creditos - debitos;
        }
    }
}
