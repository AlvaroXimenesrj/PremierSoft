using Questao2._1.Application.Dtos;
using Questao2._2.Services.Dtos;

namespace Questao2._2.Services.Interfaces
{
    public interface IFootballMatchesService
    {
        Task<HttpResultDto> GetMatches(ParametersDto parameters);
    }
}
