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
    public class FixturesRepository
    {
        public List<Fixtures> _fixtures = new List<Fixtures>();

        public FixturesRepository(int leagueId)
        {

            string url = CreateUrl(leagueId);
            string json = CallRestMethod(url);

            JObject jsonObject = JObject.Parse(json);
            var fixtures = jsonObject["matches"].ToList();

            for (int i = 0; i < fixtures.Count; i++)
            {
                _fixtures.Add(new Fixtures
                {
                    UtcDate = (string)fixtures[i]["utcDate"],
                    Status = (string)fixtures[i]["status"],
                    Matchday = (int)fixtures[i]["matchday"],
                    //ScoreFulltimeHomeTeam = (int)fixtures[i]["score"][0]["fullTime"][0]["homeTeam"],
                    //ScoreFulltimeAwayTeam = (int)fixtures[i]["score"],
                    //HomeTeamName = (string)fixtures[i]["homeTeamName"],
                    //AwayTeamName = (string)fixtures[i]["awayTeamName"]

                });
            }

        }

        public List<Fixtures> GetFixtures()
        {
            return _fixtures;
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
            return "http://api.football-data.org/v2/competitions/"+leagueId+"/matches";
        }
    }
}
