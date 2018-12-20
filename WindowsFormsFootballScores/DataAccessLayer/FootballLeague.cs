using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FootballLeague
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string League { get; set; }
        public int Year { get; set; }
        public int CurrentMatchday { get; set; }
        public int NumberOfMatchdays { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfGames { get; set; }
        public string LastUpdated { get; set; }
        public string Teams { get; set; }
        public string Fixture { get; set; }
        public string LeagueTable { get; set; }
    }
}
