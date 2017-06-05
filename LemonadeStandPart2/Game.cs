using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Game
    {
        public Player playerOne;
        private string lengthPreferance;
        private Random random;

        public string LengthPreferance { get { return lengthPreferance; } set { lengthPreferance = value; } }

        public void BeginPlay()
        {
            random = new Random();
            UInterface.ShowInitiator();
            GetTheirName();
            UInterface.ShowRules(playerOne);
            GetLengthPreferance();
            UInterface.PrompNewGame(new Game());
        }

        private void GetTheirName()
        {
            playerOne = new Player("Lionel Lemon", random);
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            playerOne.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private void GetLengthPreferance()
        {
            Console.WriteLine("CHOOSE YOUR LENGTH OF THE GAME: ");
            Console.WriteLine();
            Console.WriteLine("Input '1', '2' or '3': ");
            Console.WriteLine("[1] Four Days");
            Console.WriteLine("[2] Seven Days");
            Console.WriteLine("[3] Two Weeks");
            lengthPreferance = Console.ReadLine();
            if (lengthPreferance == "1")
            {
                RunFourDay();
            }
            else if (lengthPreferance == "2")
            {
                RunSevenDay();
            }
            else if (lengthPreferance == "3")
            {
                RunFourteenDay();
            }
            Console.WriteLine();
            if (lengthPreferance != "1" && lengthPreferance != "2" && lengthPreferance != "3")
            {
                Console.WriteLine("Enter a the response '1', '2' or '3'.");
                GetLengthPreferance();
            }
        }

        private void RunDayOne()
        {
            UInterface.DisplayCash(playerOne);
            UInterface.DisplayInventory(playerOne);
            Day toDay = new Day(random);
            PrompInvRefill();
            Lemonade recipe = new Lemonade();
            playerOne.Store.SellProduct(toDay, recipe);
            playerOne.Store.CalculateDaysNegativeProfit(toDay.Sales);
            playerOne.Store.CalculateTotalProfit(toDay.Sales);
            UInterface.ShowDailySynopsis(playerOne, toDay);
            playerOne.Store.DaysOpen += 1;
            playerOne.Store.SyncBalance(toDay.Sales);
        }

        private void RunFourDay()
        {
            while (playerOne.Store.DaysOpen != 5)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunDayOne();
            }
            ShowDailyResult();
        }

        private void RunSevenDay()
        {
            while (playerOne.Store.DaysOpen != 8)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunDayOne();
            }
            ShowDailyResult();
        }

        private void RunFourteenDay()
        {
            while (playerOne.Store.DaysOpen != 15)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunDayOne();
            }
            ShowDailyResult();
        }

        private void PrompInvRefill()
        {
            Console.WriteLine("Care to refill your stock? Enter 'yes' or 'no': ");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                playerOne.Store.RefillInventory();
            }
            else if (response == "no")
            {
                Console.WriteLine();
            }
            else if (response != "yes" && response != "no")
            {
                Console.WriteLine("Please input 'yes' or 'no' as a response.");
                Console.WriteLine();
                PrompInvRefill();
            }
        }

        private void ShowDailyResult()
        {

        }
    }
}
