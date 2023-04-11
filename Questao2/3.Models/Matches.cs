using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2._3.Models
{
    public class Matches
    {

        public string TeamName { get; set; }
        public int totalGoals { get; set; }
        public int year { get; set; }

        public override string ToString()
        {
            return "Team " + TeamName + " scored " + totalGoals.ToString() + " goals in " + year;
        }

    }
}
