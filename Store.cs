using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Store
    {
        private Inventory inventory;
        private double money;
        private double dailyNegativeProfit;
        private double runningNegativeProfit;
        private int daysAvailable;
        private Random random;
        private Player player1;
        private double dailyExpenses;

        public Inventory Inventory { get { return inventory; } }
        public double Money { get { return money; } set { money = value; } }
        public double DailyMoneyLoss { get { return dailyNegativeProfit; } set { dailyNegativeProfit = value; } }
        public double RunningNegativeProfit { get { return runningNegativeProfit; } set { runningNegativeProfit = value; } }
        public int DaysOpen { get { return daysAvailable; } set { daysAvailable = value; } }
        public double DailyExpenses { get { return dailyExpenses; } set { dailyExpenses = value; } }

        public Store(Random Random, Player Player1)
        {
            random = Random;
            inventory = new Inventory();
            money = 350;
            daysAvailable = 1;
            player1 = Player1;
        }

        public void RefillInventory()
        {
            dailyExpenses = 0;
            UInterface.DisplayPurchasePrices(new Cup(), new Lemon(), new Sugar(), new Ice());
            Console.WriteLine("Enter amount for each. If you don't need a certain product, enter '0'.");
            Console.WriteLine("Cups: ");
            int cupAmount = int.Parse(Console.ReadLine());
            if (cupAmount != 0)
            {
                inventory.AddCups(cupAmount);
                dailyExpenses += (cupAmount * new Cup().Price);
                money -= (cupAmount * new Cup().Price);
            }
            UInterface.DisplayCash(player1);
            Console.WriteLine("Lemons: ");
            int lemonAmount = int.Parse(Console.ReadLine());
            if (lemonAmount != 0)
            {
                inventory.AddLemon(lemonAmount);
                dailyExpenses += (lemonAmount * new Cup().Price);
                money -= (cupAmount * new Lemon().Price);
            }
            UInterface.DisplayCash(player1);
            Console.WriteLine("Sugar: ");
            int sugarAmount = int.Parse(Console.ReadLine());
            if (sugarAmount != 0)
            {
                inventory.AddSugar(sugarAmount);
                dailyExpenses += (sugarAmount * new Cup().Price);
                money -= (cupAmount * new Sugar().Price);
            }
            UInterface.DisplayCash(player1);
            Console.WriteLine("Ice: ");
            int iceAmount = int.Parse(Console.ReadLine());
            if (iceAmount != 0)
            {
                inventory.AddIce(iceAmount);
                dailyExpenses += (iceAmount * new Cup().Price);
                money -= (cupAmount * new Ice().Price);
            }
            UInterface.DisplayCash(player1);
            Console.WriteLine("Inventory updated.");
            UInterface.DisplayInventory(player1);
            Console.WriteLine();
        }

        public void SellProduct(Day toDay, Lemonade lemonade)
        {
            for (int i = 0; i < toDay.PotentialClients.Count; i++)
            {
                if (toDay.PotentialClients[i].MaxAmountPay < lemonade.PricePerCup)
                {
                    toDay.PotentialClients[i].CupsSold = 0;
                }
                else if (toDay.PotentialClients[i].MaxAmountPay >= lemonade.PricePerCup)
                {
                    if (toDay.PotentialClients[i].LemonPreference == lemonade.LemonSupply && toDay.PotentialClients[i].SugarPreference == lemonade.SugarSupply && toDay.PotentialClients[i].IcePreference == lemonade.IceSupply)
                    {
                        toDay.PotentialClients[i].CupsSold = 3;
                        toDay.Sales += (3 * lemonade.PricePerCup);
                        toDay.Customers.Add(toDay.PotentialClients[i]);
                        if (!inventory.SubtractLemons(3 * lemonade.LemonSupply))
                        {
                            UInterface.AlertZeroProduct("Lemons");
                            break;
                        }
                        if (!inventory.SubtractSugar(2 * lemonade.SugarSupply))
                        {
                            UInterface.AlertZeroProduct("Sugar");
                            break;
                        }
                        if (!inventory.RemoveIce(2 * lemonade.IceSupply))
                        {
                            UInterface.AlertZeroProduct("Ice");
                            break;
                        }
                        if (!inventory.RemoveCups(2))
                        {
                            UInterface.AlertZeroProduct("Cups");
                            break;
                        }
                    }
                    else
                    {
                        int amount = random.Next(3);
                        if (amount == 0)
                        {
                            toDay.PotentialClients[i].CupsSold = 0;
                        }
                        else if (amount == 1)
                        {
                            toDay.PotentialClients[i].CupsSold = 1;
                            toDay.Sales += lemonade.PricePerCup;
                            toDay.Customers.Add(toDay.PotentialClients[i]);
                            if (!inventory.SubtractLemons(lemonade.LemonSupply))
                            {
                                UInterface.AlertZeroProduct("Lemons");
                                break;
                            }
                            if (!inventory.SubtractSugar(lemonade.SugarSupply))
                            {
                                UInterface.AlertZeroProduct("Sugar");
                                break;
                            }
                            if (!inventory.RemoveIce(lemonade.IceSupply))
                            {
                                UInterface.AlertZeroProduct("Ice");
                                break;
                            }
                            if (!inventory.RemoveCups(1))
                            {
                                UInterface.AlertZeroProduct("Cups");
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void SyncBalance(double sales)
        {
            money += sales;
        }

        public void CalculateDaysNegativeProfit(double dailySales)
        {
            dailyNegativeProfit = dailySales - dailyExpenses;
        }

        public void CalculateTotalProfit(double dailySales)
        {
            if (money < 500)
            {
                runningNegativeProfit = 500 - money;
            }
            else if (money > 500)
            {
                runningNegativeProfit = ((money + dailySales) - 500);
            }
        }
    }
}
