namespace Questao5.Application.Queries.Responses
{
    public class MovimentacaoDto
    {
        public string Id { get; set; }
        public string ContaCorrenteID { get; set; }
        public string DataMovimento { get; set; }
        public string TipoMovimento { get; set; }
        public decimal Valor { get; set; }
    }
}
