using Questao2._2.Services.Dtos;
using Questao2._3.Models;


namespace Questao2._1.Application.Mapping
{
    public static class DtoToMatchesExtensionMapping
    {
        public static void ToMathesMapping(this Matches matches, HttpResultDto httpResult, string team, int year)
        {
            matches.year = year;
            matches.TeamName = team;           
            var totalGoals = httpResult.data.Select(r => r.team1goals).Sum();
            matches.totalGoals = totalGoals;
            
        }
    }
}
