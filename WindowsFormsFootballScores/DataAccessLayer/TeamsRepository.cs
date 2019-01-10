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

        public TeamsRepository()
        {

            string url = "http://api.football-data.org/v1/soccerseasons";
            string json = CallRestMethod(url);

            JArray jsonObject = JArray.Parse(json);

            foreach (JObject item in jsonObject)
            {
                _teams.Add(new Teams
                {
                    Name = (string)item.GetValue("name"),
                    Code = (string)item.GetValue("code"),
                    ShortName = (string)item.GetValue("shortName"),
                    SquadMarketValue = (string)item.GetValue("squadMarketValue"),
                    TeamLogo = (string)item.GetValue("crestURI")
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
