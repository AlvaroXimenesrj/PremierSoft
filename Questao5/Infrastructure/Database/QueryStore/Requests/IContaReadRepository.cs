using Questao5.Application.Queries.Responses;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public interface IContaReadRepository
    {
        Task<ContaDetalheDTO> GetContabyId(int id);
    }
}
