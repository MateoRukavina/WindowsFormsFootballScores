using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace DataAccessLayer
{
    public class FootbalLeagueRepository
    {
        public List<FootballLeague> _footballleague = new List<FootballLeague>();

        public FootbalLeagueRepository()
        {

            string url = "http://api.football-data.org/v2/competitions";
            string json = CallRestMethod(url);

            JObject jsonObject = JObject.Parse(json);
            var competitions = jsonObject["competitions"].ToList();
            
            for (int i = 0; i < competitions.Count; i++)
            {   
                //Console.WriteLine(competitions[i]["area"].SelectToken("name"));      
                _footballleague.Add(new FootballLeague
                {
                    Id = (int)competitions[i]["id"],
                    AreaName = (string)competitions[i]["area"].SelectToken("name"),
                    Name = (string)competitions[i]["name"],
                    Code = (string)competitions[i]["code"],
                    Plan = (string)competitions[i]["plan"],
                    CurrentSeasonStartDate = (string)competitions[i]["currentSeason"].SelectToken("startDate"),
                    CurrentSeasonEndDate = (string)competitions[i]["currentSeason"].SelectToken("endDate"),
                    CurrentMatchday = (int)competitions[i]["currentSeason"].SelectToken("currentMatchday"), 
                    LastUpdated = (string)competitions[i]["lastUpdated"]
                });
            }

        }

        public List<FootballLeague> GetFootballScores()
        {
            return _footballleague;
        }

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            webrequest.Headers.Add("X-Auth-Token", "898aab2093234bedb6c9523979193284");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
