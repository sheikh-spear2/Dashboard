using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Dashboard.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using iTextSharp.tool.xml.html;

namespace Dashboard.Controllers
{
    public class OpenWeatherApiController : Controller
    {
        public OpenWeatherMap FillCity()
        {
            OpenWeatherMap openWeatherMap = new OpenWeatherMap();
            openWeatherMap.cities = new Dictionary<string, int>();
            openWeatherMap.cities.Add("Melbourne", 7839805);
            openWeatherMap.cities.Add("Auckland", 2193734);
            openWeatherMap.cities.Add("New Delhi", 1261481);
            openWeatherMap.cities.Add("Abu Dhabi", 292968);
            openWeatherMap.cities.Add("Lahore", 1172451);
            return openWeatherMap;
        }
        public IActionResult Index()
        {
            OpenWeatherMap openWeatherMap = FillCity();
            return View(openWeatherMap);
        }
        [HttpPost]
        public ActionResult Index(OpenWeatherMap openWeatherMap, string cities)
        {
            openWeatherMap = FillCity();

            if (cities != null)
            {
                /*Calling API http://openweathermap.org/api */
                string apiKey = "61dda8e5b0d2ba353473d60e9d6a7646";
                HttpWebRequest apiRequest =
                WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?id=" +
                cities + "&appid=" + apiKey + "&units=metric") as HttpWebRequest;

                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                }
                /*End*/

                /*http://json2csharp.com*/
                ResponseWeather rootObject = JsonConvert.DeserializeObject<ResponseWeather>(apiResponse);

                StringBuilder sb = new StringBuilder();
                sb.Append("<table><tr><th>Weather Description</th></tr>");
                sb.Append("<tr><td>City:</td><td>" +
                rootObject.name + "</td></tr>");
                sb.Append("<tr><td>Country:</td><td>" +
                rootObject.sys.country + "</td></tr>");
                sb.Append("<tr><td>Wind:</td><td>" +
                rootObject.wind.speed + " Km/h</td></tr>");
                sb.Append("<tr><td>Current Temperature:</td><td>" +
                rootObject.main.temp + " °C</td></tr>");
                sb.Append("<tr><td>Humidity:</td><td>" +
                rootObject.main.humidity + "</td></tr>");
                sb.Append("<tr><td>Weather:</td><td>" +
                rootObject.weather[0].description + "</td></tr>");
                sb.Append("</table>");
                openWeatherMap.apiResponse = sb.ToString();
            }
            else
            {
                if (Request.Form["submit"] != "")
                {
                    openWeatherMap.apiResponse = "► Select City";
                }
            }
            return View(openWeatherMap);
        }
    }
}