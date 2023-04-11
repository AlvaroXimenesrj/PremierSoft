using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class ContaWriteRepository : IContaWriteRepository
    {
        public async Task<int> Movimentar(ContaCorrente conta)
        {
            return 2;
        }
    }
}
