using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiWeather
{
    public class TempInf
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        [JsonProperty(PropertyName = "city_name")]
        public string City_name { get; set; }

        [JsonProperty(PropertyName = "temp")]
        public double Temp { get; set; }

        [JsonProperty(PropertyName = "condition_slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "condition_code")]
        public string Codigo { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public string Umidade { get; set; }

        [JsonProperty(PropertyName = "rain")]
        public string Chuva { get; set; }

        [JsonProperty(PropertyName = "wind_speedy")]
        public string Vento { get; set; }

        [JsonProperty(PropertyName = "sunset")]
        public string SolPor { get; set; }

        [JsonProperty(PropertyName = "sunrise")]
        public string SolSe { get; set; }

    }
}
