using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Day
    {

        private Weather todaysWeather;
        private List<Client> customers;
        private List<Client> potentialCustomers;
       
        private double sales;
        private Random random;

        public Weather TodaysWeather { get { return todaysWeather; } }
        public int TotalCustomers { get { return customers.Count; } }
        public List<Client> Customers { get { return customers; } set { customers = value; } }
        public List<Client> PotentialClients { get { return potentialCustomers; } set { potentialCustomers = value; } }
        public double Sales { get { return sales; } set { sales = value; } }

        public Day(Random Random)
        {
            random = Random;
            todaysWeather = new Weather(random);
            customers = new List<Client>();
            potentialCustomers = new List<Client>();
            SetPotentialCustomers();
            
            sales = 0;
        }

        private void SetPotentialCustomers()
        {
            if (todaysWeather.ClientProbability == "low")
            {
                while (potentialCustomers.Count <= 25)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "medium")
            {
                while (potentialCustomers.Count <= 75)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "high")
            {
                while (potentialCustomers.Count <= 177)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "very high")
            {
                while (potentialCustomers.Count <= 325)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
        }
    }
}