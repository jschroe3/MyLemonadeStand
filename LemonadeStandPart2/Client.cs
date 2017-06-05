using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Client
    {
        private double highAmountToPay;
        private int lemonLeaning;
        private int sugarLeaning;
        private int iceLeaning;
        private int probabilityOfPurchase;
        private int cupsPurchased;
        private Random random;

        public double MaxAmountPay { get { return highAmountToPay; } }
        public int LemonPreference { get { return lemonLeaning; } }
        public int SugarPreference { get { return sugarLeaning; } }
        public int IcePreference { get { return iceLeaning; } }
        public int ProbOfPurchase { get { return probabilityOfPurchase; } }
        public int CupsSold { get { return cupsPurchased; } set { cupsPurchased = value; } }

        public Client(Random Random)
        {
            random = Random;
            highAmountToPay = SetMaxAmountPay();
            probabilityOfPurchase = FindProbOfPurchase();
            lemonLeaning = SetLemonPreference();
            sugarLeaning = SetSugarPreference();
            iceLeaning = SetIcePreference();
            cupsPurchased = 0;
        }

        private double SetMaxAmountPay()
        {
            highAmountToPay = random.NextDouble() * (6 - 1) + 1;
            highAmountToPay = Math.Round(highAmountToPay, 2);
            return highAmountToPay;
        }

        private int FindProbOfPurchase()
        {
            int amount = random.Next(12);
            return probabilityOfPurchase;
        }

        private int SetLemonPreference()
        {
            lemonLeaning = random.Next(1, 6);
            return lemonLeaning;
        }

        private int SetSugarPreference()
        {
            sugarLeaning = random.Next(1, 7);
            return sugarLeaning;
        }

        private int SetIcePreference()
        {
            iceLeaning = random.Next(1, 12);
            return iceLeaning;
        }
    }
}