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
            int leagueId = 2021;
            /*var repo = new StandingsRepository(leagueId);
            var standings = repo.GetLeagueTable();
            foreach (var standing in standings)
            {
                Console.WriteLine(standing.Position);
                Console.WriteLine(standing.TeamLogo);
                Console.WriteLine(standing.TeamName);
                Console.WriteLine(standing.PlayedGames);
                Console.WriteLine(standing.Wins);
                Console.WriteLine(standing.Draws);
                Console.WriteLine(standing.Losses);
                Console.WriteLine(standing.GoalsFor);
                Console.WriteLine(standing.GoalsAgainst);
                Console.WriteLine(standing.GoalDifference);
                Console.WriteLine(standing.Points);
                Console.WriteLine("");

            }*/
            /*var repo = new FixturesRepository(leagueId);
            var fixtures = repo.GetFixtures();
            foreach (var fixture in fixtures)
            {
                Console.WriteLine(fixture.UtcDate);
                Console.WriteLine(fixture.Status);
                Console.WriteLine(fixture.Matchday);
                //Console.WriteLine(fixture.HomeTeamName);
                //Console.WriteLine(fixture.AwayTeamName);
                //Console.WriteLine(fixture.ScoreFulltimeHomeTeam);
                //Console.WriteLine(fixture.ScoreFulltimeAwayTeam);
                Console.WriteLine("");

            }*/
            var repo = new FootbalLeagueRepository();
            var leagues = repo.GetFootballScores();
            foreach (var league in leagues)
            {
                Console.WriteLine(league.Id);
                Console.WriteLine(league.AreaName);
                Console.WriteLine(league.Name);
                Console.WriteLine(league.Code);
                Console.WriteLine(league.Plan);
                Console.WriteLine(league.CurrentSeasonStartDate);
                Console.WriteLine(league.CurrentSeasonEndDate);
                Console.WriteLine(league.CurrentMatchday);
                Console.WriteLine(league.LastUpdated);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
