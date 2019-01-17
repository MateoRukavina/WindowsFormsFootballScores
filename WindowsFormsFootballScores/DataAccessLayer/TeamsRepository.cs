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
    public class TeamsRepository
    {
        public List<Teams> _teams = new List<Teams>();

        public TeamsRepository(int leagueId)
        {

            string url = CreateUrl(leagueId);
            string json = CallRestMethod(url);

            JObject jsonObject = JObject.Parse(json);
            var teams = jsonObject["teams"].ToList();

            for (int i = 0; i < teams.Count; i++)
            {
                _teams.Add(new Teams
                {
                    Name = (string)teams[i]["name"],
                    ShortName = (string)teams[i]["shortName"],
                    Tla = (string)teams[i]["tla"],
                    TeamLogo = (string)teams[i]["crestUrl"],
                    Address = (string)teams[i]["address"],
                    Phone = (string)teams[i]["phone"],
                    Website = (string)teams[i]["website"],
                    Email = (string)teams[i]["email"],
                    Founded = (int)teams[i]["founded"],
                    ClubColors = (string)teams[i]["clubColors"],
                    Venue = (string)teams[i]["venue"]
                });
            }

        }

        public List<Teams> GetTeams()
        {
            return _teams;
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
            return "http://api.football-data.org/v2/competitions/" + leagueId + "/matches";
        }
    }
}
