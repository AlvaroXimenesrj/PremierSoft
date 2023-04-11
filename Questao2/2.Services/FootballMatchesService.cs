using Questao2._1.Application.Dtos;
using Questao2._2.Services.Dtos;
using Questao2._2.Services.Interfaces;

namespace Questao2._2.Services
{
    public class FootballMatchesService : IFootballMatchesService
    {
        private IHttpRequest _httpRequest = new HttpRequest();

        public async Task<HttpResultDto> GetMatches(ParametersDto parameters)
        {
            var result = await _httpRequest.Get(parameters);

            if(result.total_pages > 1)
            {
                var totalPages = result.total_pages;
                
                return await _httpRequest.GetAll(parameters, totalPages);
            }
          
            
            return result;
        }
    }
}
