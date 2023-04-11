using Questao2._1.Application.Dtos;
using Questao2._2.Services.Dtos;
using Questao2._2.Services.Interfaces;

namespace Questao2._2.Services
{
    public class HttpRequest : IHttpRequest
    {
        private string url = "https://jsonmock.hackerrank.com/api/football_matches";
        private HttpClient _httpClient = new HttpClient();
        private HttpResultDto _httpResult = new HttpResultDto();
        public async Task<HttpResultDto> Get(ParametersDto parameters)
        {
            var baseUrl = $"{url}?year={parameters.Year}&team1={parameters.Team}";
            
            var result = await _httpClient.GetStringAsync(baseUrl);

            _httpResult = _httpResult.HttpResulToDataConvert(result);

            return _httpResult;
        }

        public async Task<HttpResultDto> GetAll(ParametersDto parameters, int totalPages)
        {
            var baseUrl = $"{url}?year={parameters.Year}&team1={parameters.Team}&page=";  
            
            var urls = Enumerable.Range(1, totalPages).Select(i => $"{baseUrl}{i}");

            var tasks =  urls.Select(url => _httpClient.GetStringAsync(url));

            string[] contents = await Task.WhenAll(tasks);

            var result = _httpResult.HttpResultListToDataConvert(contents);

            return result;
        }
    }
}
