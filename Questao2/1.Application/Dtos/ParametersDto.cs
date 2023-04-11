using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2._1.Application.Dtos
{
    public class ParametersDto
    {
        public ParametersDto(string team, int year)
        {
            Team = team;
            Year = year;
        }
        public string Team { get; set; }
        public int Year { get; set; }
    }
}
