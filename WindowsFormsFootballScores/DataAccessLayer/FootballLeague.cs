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
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Plan { get; set; }
        public string CurrentSeasonStartDate { get; set; }
        public string CurrentSeasonEndDate { get; set; }
        public int CurrentMatchday { get; set; }
        public string LastUpdated { get; set; }
    }
}
