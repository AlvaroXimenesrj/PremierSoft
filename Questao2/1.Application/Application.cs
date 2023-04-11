using Questao2._1.Application.Dtos;
using Questao2._1.Application.Interfaces;
using Questao2._1.Application.Mapping;
using Questao2._2.Services;
using Questao2._2.Services.Interfaces;
using Questao2._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2._1.Application
{
    public class Application : IApplication
    {
        private IFootballMatchesService _matchesService = new FootballMatchesService();
        private Matches matches = new Matches();
        public Application()
        {

        }
        public async Task<Matches> Get(string team, int year)
        {
            var parameters = new ParametersDto(team,year);

            var result = await _matchesService.GetMatches(parameters);
                    
            matches.ToMathesMapping(result, team, year);

            return matches;
        }
    }
}
