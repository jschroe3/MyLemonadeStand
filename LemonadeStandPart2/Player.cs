using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Player
    {
        private string name;
        private Store store;
        private double endScore;
        private double peakScore;

        public string Name { get { return name; } set { name = value; } }
        public Store Store { get { return store; } }
        public double EndScore { get { return endScore; } set { endScore = value; } }
        public double PeakScore { get { return peakScore; } set { peakScore = value; } }

        public Player(string Name, Random random)
        {
            name = Name;
            store = new Store(random, this);
        }
    }
}