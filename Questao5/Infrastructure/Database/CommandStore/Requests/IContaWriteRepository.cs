using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public interface IContaWriteRepository
    {
        Task<int> Movimentar(ContaCorrente conta);
    }
}
