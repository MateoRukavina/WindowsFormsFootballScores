using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new FootbalLeagueRepository();
            var leagues = repo.GetFootballScores();
            foreach (var league in leagues)
            {
                Console.WriteLine(league.Id);
                Console.WriteLine(league.Caption);
                Console.WriteLine(league.League);
                Console.WriteLine(league.Year);
                Console.WriteLine(league.CurrentMatchday);
                Console.WriteLine(league.NumberOfMatchdays);
                Console.WriteLine(league.NumberOfTeams);
                Console.WriteLine(league.NumberOfGames);
                Console.WriteLine(league.LastUpdated);
                Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}
