using Newtonsoft.Json;
using Questao2._1.Application;
using Questao2._1.Application.Interfaces;
using Questao2._3.Models;

public class Program
{
    public static async Task Main()
    {
        string teamName = "Paris Saint-Germain";        
        int year = 2013;
        var matches = await getTotalScoredGoals(teamName, year);

        Console.WriteLine(matches.ToString());

        teamName = "Chelsea";
        year = 2014;
        matches = await getTotalScoredGoals(teamName, year);

        Console.WriteLine(matches.ToString());

        
        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    public static async Task<Matches> getTotalScoredGoals(string team, int year)
    {
        IApplication _application = new Application();
        var matches = await _application.Get(team, year);

        return matches;
    }

}