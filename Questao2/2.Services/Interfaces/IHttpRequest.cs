using Questao2._1.Application.Dtos;
using Questao2._2.Services.Dtos;

namespace Questao2._2.Services.Interfaces
{
    public interface IHttpRequest
    {
        Task<HttpResultDto> Get(ParametersDto parameters);
        Task<HttpResultDto> GetAll(ParametersDto parameters,int totalPages);
    }
}
