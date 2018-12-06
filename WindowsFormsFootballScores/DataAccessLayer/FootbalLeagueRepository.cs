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

            string url = "http://api.football-data.org/v1/soccerseasons";
            string json = CallRestMethod(url);

            JArray jsonObject = JArray.Parse(json);

            foreach (JObject item in jsonObject)
            {
                _footballleague.Add(new FootballLeague
                {
                    Id = (int)item.GetValue("id"),
                    Caption = (string)item.GetValue("caption"),
                    League = (string)item.GetValue("league"),
                    Year = (int)item.GetValue("year"),
                    CurrentMatchday = (int)item.GetValue("currentMatchday"),
                    NumberOfMatchdays = (int)item.GetValue("numberOfMatchdays"),
                    NumberOfTeams = (int)item.GetValue("numberOfTeams"),
                    NumberOfGames = (int)item.GetValue("numberOfGames"),
                    LastUpdated = (string)item.GetValue("lastUpdated")
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
