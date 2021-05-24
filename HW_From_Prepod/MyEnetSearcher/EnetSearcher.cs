using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HW_From_Prepod.MyWeatherModel;

namespace HW_From_Prepod.MyEnetSearcher
{
    class EnetSearcher
    {
        static List<string> urls;

        static EnetSearcher()
        {
            urls = new List<string>
            {
                @"https://xml.meteoservice.ru/export/gismeteo/point/113.xml",
                @"https://xml.meteoservice.ru/export/gismeteo/point/37.xml",
                @"https://xml.meteoservice.ru/export/gismeteo/point/69.xml"
            };
        }

        HttpClient httpClient;

        public EnetSearcher()
        {
            httpClient = new HttpClient();
        }

        public ObservableCollection<WeatherModel> GetWeatherModels(string City)
        {
            string url = string.Empty;
            if (City == "Мурманск") url = urls[0];
            if (City == "Москва") url = urls[1];
            if (City == "Питер") url = urls[2];

            ObservableCollection<WeatherModel> temp = new ObservableCollection<WeatherModel>();

            var req = httpClient.GetStringAsync(url).Result;

            var colWeather = XDocument.Parse(req).Descendants("MMWEATHER")
                                            .Descendants("REPORT")
                                            .Descendants("TOWN")
                                            .Descendants("FORECAST").ToList();

            foreach (var FORECAST in colWeather)
            {
                temp.Add(
                    new WeatherModel()
                    {
                        DateD = FORECAST.Attribute("day").Value,
                        DateM = FORECAST.Attribute("month").Value,
                        DateY = FORECAST.Attribute("year").Value,
                        DateH = FORECAST.Attribute("hour").Value,
                        TEMPERATUREmin = FORECAST.Element("TEMPERATURE").Attribute("min").Value,
                        TEMPERATUREmax = FORECAST.Element("TEMPERATURE").Attribute("max").Value,
                        PRESSUREmin = FORECAST.Element("PRESSURE").Attribute("min").Value,
                        PRESSUREmax = FORECAST.Element("PRESSURE").Attribute("max").Value,
                        WINDmin = FORECAST.Element("WIND").Attribute("min").Value,
                        WINDmax = FORECAST.Element("WIND").Attribute("max").Value
                    }
                    );
            }
            return temp;
        }      
    }
}
