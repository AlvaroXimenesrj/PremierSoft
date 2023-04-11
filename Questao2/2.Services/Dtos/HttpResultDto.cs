using Newtonsoft.Json.Linq;
using System.Linq;

namespace Questao2._2.Services.Dtos
{
    public class HttpResultDto
    {
        public HttpResultDto()
        {
            data = new List<DataResult>();
        }
        public int pages { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }

        public List<DataResult> data { get; set; }

        public HttpResultDto HttpResultListToDataConvert(string[] httpResults)
        {
            var returnDto = new HttpResultDto();

            foreach (var content in httpResults)
            {
                var httpResultDto = System.Text.Json.JsonSerializer.Deserialize<HttpResultDto>(content);

                returnDto.data.AddRange(httpResultDto!.data);
            }

            return returnDto;
        }

        public HttpResultDto HttpResulToDataConvert(string httpResult)
        {            
                return System.Text.Json.JsonSerializer.Deserialize<HttpResultDto>(httpResult);                
        }
    }
}
