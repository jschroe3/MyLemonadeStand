using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public static class UInterface
    {
        public static void ShowInitiator()
        {
            Console.WriteLine("Looking to start your own Lemonade Company?");
            Console.WriteLine();
        }

        public static void ShowRules(Player player1)
        {
            Console.WriteLine();
            Console.WriteLine($"Welcome {player1.Name}");
            Console.WriteLine("You are being challenged to produce the largest amount of money via Lemonade sales throughtout the timespan of 4, 7 or 14 days.");
            Console.WriteLine("You start with $350 and an empty inventory.");
            Console.WriteLine("The variables affecting your sales / profit are the Weather and your choice of Recipe");
            Console.WriteLine("First set the price you determine your lemonade to be worth on that specific day. Then determine how much Sugar, Lemon and Ice you wish to use in construction of your Lemonade.");
            Console.WriteLine("Once the day is completed, your score for that day, as well as, your overall score with be displayed.");
            Console.WriteLine("You can then determine whether you want to continue or file for welfare.");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void DisplayInventory(Player playerOne)
        {
            Console.WriteLine();
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine();
            Console.WriteLine($"Cups: {playerOne.Store.Inventory.Cups}");
            Console.WriteLine($"Lemons: {playerOne.Store.Inventory.Lemons}");
            Console.WriteLine($"Sugar: {playerOne.Store.Inventory.Sugar}");
            Console.WriteLine($"Ice: {playerOne.Store.Inventory.Ice}");
            Console.WriteLine();
        }

        public static void AlertZeroProduct(string product)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Apparently you forgot the amount of {product} you DIDNT have...");
            Console.WriteLine("Try recalling you Stock levels so I don't have to remind you... Thankkkss.");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void DisplayCash(Player player1)
        {
            Console.WriteLine($"Your Balance: ${player1.Store.Money}");
        }

        public static void DisplayPurchasePrices(Cup cup, Lemon lemon, Sugar sugar, Ice ice)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cost to Purchase:");
            Console.WriteLine($"Cup: ${cup.Price}");
            Console.WriteLine($"Lemon: ${lemon.Price}");
            Console.WriteLine($"Sugar: ${sugar.Price}");
            Console.WriteLine($"Ice: ${ice.Price}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ShowDailySynopsis(Player player1, Day currentDay)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Daily Recap {player1.Store.DaysOpen}: ");
            Console.WriteLine($">Total Revenue: ${currentDay.Sales}");
            Console.WriteLine($">Daily Customer Amount: {currentDay.TotalCustomers}");
            Console.WriteLine($">Daily Profit / Loss: {player1.Store.DailyMoneyLoss}");
            if (player1.Store.Money < 350)
            {
                Console.WriteLine($">Total Profit / Loss: - ${player1.Store.RunningNegativeProfit}");
            }
            else if (player1.Store.Money > 350)
            {
                Console.WriteLine($">Total Profit / Loss: + ${player1.Store.RunningNegativeProfit}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrompNewGame(Game game)
        {
            Console.WriteLine();
            Console.WriteLine("Care to dabble again? Input 'yes' or 'no'.");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                Console.Clear();
                game.BeginPlay();
            }
            else if (response == "no")
            {
                Console.Clear();
                Console.WriteLine("Hope you wallet grew in size!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hit [Enter] to quit.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Type 'yes' or 'no' in the Console.");
                Console.WriteLine();
                PrompNewGame(game);
            }
        }
    }
}