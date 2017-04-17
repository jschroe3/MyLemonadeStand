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
        //private Lemonade lemonade;
        private double sales;
        private Random random;

        public Weather TodaysWeather { get { return todaysWeather; } }
        //public Lemonade Lemonade { get { return lemonade; } }
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
            //lemonade = new Lemonade();
            sales = 0;
        }

        private void SetPotentialCustomers()
        {
            if (todaysWeather.ClientProbability == "low")
            {
                while (potentialCustomers.Count <= 50)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "medium")
            {
                while (potentialCustomers.Count <= 100)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "high")
            {
                while (potentialCustomers.Count <= 150)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
            else if (todaysWeather.ClientProbability == "very high")
            {
                while (potentialCustomers.Count <= 200)
                {
                    potentialCustomers.Add(new Client(random));
                }
            }
        }
    }
}