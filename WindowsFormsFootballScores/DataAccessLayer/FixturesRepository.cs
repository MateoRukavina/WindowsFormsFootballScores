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
                var fixtures = jsonObject["fixtures"].ToList();

                for (int i = 0; i < fixtures.Count; i++)
                {
                    _fixtures.Add(new Fixtures
                    {
                        Date = (string)fixtures[i]["date"],
                        Status = (string)fixtures[i]["status"],
                        Matchday = (int)fixtures[i]["matchday"],
                        HomeTeamName = (string)fixtures[i]["homeTeamName"],
                        AwayTeamName = (string)fixtures[i]["awayTeamName"],
                        //ResultGoalsHomeTeam = (int)fixtures[i]["goalsHomeTeam"],
                        //ResultGoalsAwayTeam = (int)fixtures[i]["goalsAwayTeam"]
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
            return "http://api.football-data.org/v1/competitions/" + leagueId + "/fixtures";
        }
    }
}
