using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Weather
    {
        private string cloudAmount;
        private string temperature;
        private string drinkDemand;
        private Random random;

        public string CloudsPresent { get { return cloudAmount; } }
        public string Temperature { get { return temperature; } }
        public string ClientProbability { get { return drinkDemand; } set { drinkDemand = value; } }

        public Weather(Random Random)
        {
            random = Random;
            GetWeather();
        }

        public void GetWeather()
        {
            GetCloudCover();
            GetTemp();
            DiscoverDemand(cloudAmount, temperature);
            DisplayWeather();
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Current Weather: ");
            Console.WriteLine("> Cloud Coverage: " + cloudAmount);
            Console.WriteLine("> Temperature: " + temperature);
            Console.WriteLine();

        }

        public string GetCloudCover()
        {
            int randomCloudCoverage = random.Next(12);

            if (randomCloudCoverage >= 0 && randomCloudCoverage <= 5)
            {
                cloudAmount = "Clear Skies";
            }
            else if (randomCloudCoverage >= 6 && randomCloudCoverage <= 8)
            {
                cloudAmount = "Dense Cloud Coverage";
            }
            else
            {
                cloudAmount = "High Percipitation";
            }
            return cloudAmount;
        }

        public string GetTemp()
        {
            int randomTemp = random.Next(12);

            if (randomTemp >= 0 && randomTemp <= 6)
            {
                temperature = "Scorching";
            }
            else if (randomTemp >= 7 && randomTemp <= 12)
            {
                temperature = "Relaxing";
            }
            else
            {
                temperature = "Chilly";
            }
            return temperature;
        }

        public string DiscoverDemand(string cloudCover, string temperature)
        {
            if (cloudCover == "Clear Skies" && temperature == "Chilly")
            {
                drinkDemand = "medium";
            }
            else if (cloudCover == "Clear Skies" && temperature == "Relaxing")
            {
                drinkDemand = "high";
            }
            else if (cloudCover == "Clear Skies" && temperature == "Scorching")
            {
                drinkDemand = "very high";
            }
            else if (cloudCover == "Dense Cloud Coverage" && temperature == "Chilly")
            {
                drinkDemand = "low";
            }
            else if (cloudCover == "Dense Cloud Coverage" && temperature == "Relaxing")
            {
                drinkDemand = "medium";
            }
            else if (cloudCover == "Dense Cloud Coverage" && temperature == "Scorching")
            {
                drinkDemand = "high";
            }
            else if (cloudCover == "High Percipitation")
            {
                drinkDemand = "low";
            }
            return drinkDemand;
        }
    }
}
