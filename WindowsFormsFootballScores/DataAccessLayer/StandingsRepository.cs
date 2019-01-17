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
    public class StandingsRepository
    {
        public List<Standings> _standings = new List<Standings>();

        public StandingsRepository(int leagueId)
        {

            string url = CreateUrl(leagueId);
            string json = CallRestMethod(url);

            JObject jsonObject = JObject.Parse(json);
            var standing = jsonObject["standings"].ToList();
            for (int i = 0; i < standing.Count; i++)
            {
                    _standings.Add(new Standings
                 {
                     Position = (int)standing[i]["position"],
                     //TeamName = (string)standing[i]["teamName"],
                     //TeamLogo = (string)standing[i]["crestURI"],
                     PlayedGames = (int)standing[i]["playedGames"],
                     Points = (int)standing[i]["points"],
                     GoalsFor = (int)standing[i]["goals"],
                     GoalsAgainst = (int)standing[i]["goalsAgainst"],
                     GoalDifference = (int)standing[i]["goalDifference"],
                     Wins = (int)standing[i]["wins"],
                     Draws = (int)standing[i]["draws"],
                     Losses = (int)standing[i]["losses"]
                 });
            }

        }

        public List<Standings> GetLeagueTable()
        {
            return _standings;
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

        public string CreateUrl(int leagueId)
        {
            return "http://api.football-data.org/v2/competitions/" + leagueId + "/standings";
        }
    }
}
