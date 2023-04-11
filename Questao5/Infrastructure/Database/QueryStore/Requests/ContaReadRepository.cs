using Questao5.Application.Queries.Responses;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public class ContaReadRepository : IContaReadRepository
    {
        public async Task<ContaDetalheDTO> GetContabyId(int id)
        {


            var conta = new ContaDetalheDTO();
            conta.Ativo = false;
            conta.Id = 123;
            conta.Numero = "12346";
            conta.Nome = "joao a silva";

            var mov1 = new MovimentacaoDto();
            mov1.Id = "2";
            mov1.ContaCorrenteID = "1234";
            mov1.DataMovimento = "2023-03-01";
            mov1.TipoMovimento = "credito";
            mov1.Valor = 100;

            var mov2 = new MovimentacaoDto();
            mov2.Id = "3";
            mov2.ContaCorrenteID = "1234";
            mov2.DataMovimento = "2023-03-02";
            mov2.TipoMovimento = "credito";
            mov2.Valor = 100;

            var mov3 = new MovimentacaoDto();
            mov3.Id = "4";
            mov3.ContaCorrenteID = "1234";
            mov3.DataMovimento = "2023-03-03";
            mov3.TipoMovimento = "debito";
            mov3.Valor = 80;

            conta.Movimentacoes.Add(mov1);
            conta.Movimentacoes.Add(mov2);
            conta.Movimentacoes.Add(mov3);
            
            return conta;

           

        }
    }
}
