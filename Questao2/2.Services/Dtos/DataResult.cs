using Questao2._1.Application.Configurations;
using System.Text.Json.Serialization;

namespace Questao2._2.Services.Dtos
{
    public class DataResult
    {
        public string competition { get; set; }
        public int year { get; set; }
        public string round { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        [JsonConverter(typeof(StringToIntConverter))]
        public int team1goals { get; set; }
        [JsonConverter(typeof(StringToIntConverter))]
        public int team2goals { get; set; }
    }
}
