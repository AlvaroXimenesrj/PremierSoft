namespace Questao5.Infrastructure.Database.QueryStore.Responses
{
    public class SaldoContaResponse
    {
        public SaldoContaResponse(string numeroConta,
                                  string nomeTitular, 
                                  decimal saldoAtual)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;            
            SaldoAtual = saldoAtual;
            HorarioConsulta = DateTime.Now;
        }

        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public DateTime HorarioConsulta { get; set; }
        public decimal SaldoAtual { get; set; }
    }
}
