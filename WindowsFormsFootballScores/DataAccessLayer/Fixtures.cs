using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Fixtures
    {
        public string Date { get; set; }
        public string Status { get; set; }
        public int Matchday { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int ResultGoalsHomeTeam { get; set; }
        public int ResultGoalsAwayTeam { get; set; }
    }
}
