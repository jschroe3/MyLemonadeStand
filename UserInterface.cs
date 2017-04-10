using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class UserInterface
    {

        public UserInterface()
        {

        }
        public void WelcomePlayer()
        {

            Console.WriteLine("You have 7 days to make as much money as possible with the lemonade stand you have just opened. You have complete control over how you're business is run, including pricing, inventory and buying supplies. Buy your supplies, set your recipe, and start making money!\n\n You will start off the game with $30.00 and will have to buy your supplies, lemons, sugar, ice, and cups. After buying your supplies you get to decide your recipe and start making money.\n\n There are a couple of things that affect the way your customers will buy. The first thing is the weather, this will determine the amount of customers that come to your stand. If the weather is hot and sunny more customers will be willing to go to your stand than if it was cold and storming. The next thing that will affect how customers buy is the price, customers will be more willin to buy if the price is lower.\n\n After each day your total profit or loss will be displayed and if you have any leftover cups of lemonade then they will spoil. The goal is to make as much money possible. Good luck!\n\nSupply Prices:\nLemons: $.15\nSugar: $.05\nIce: $.05\nCups: $.10\n\n Press enter to continue!");
            Console.ReadLine();
        }

        //public string MainMenu(Player player, Store store, Recipe recipe)
        //{
        //       Console.WriteLine("Welcome to Lemonade stand!\n\n Please type your option: 'start' new game, game 'rules', 'shop' at store, 'make' recipe, 'check' current inventory");
        //       string userInput = Console.ReadLine();

        //       switch (userInput)
        //       {
        //           case "start":
        //               RunGame();
        //               break;
        //           case "rules":
        //               Console.WriteLine("GAME RULES\n");
        //               Console.WriteLine("You have 7 days to make as much money as possible with the lemonade stand you have just opened. You have complete control over how you're business is run, including pricing, inventory and buying supplies. Buy your supplies, set your recipe, and start making money!\n\n You will start off the game with $20.00 and will have to buy your supplies, lemons, sugar, ice, and cups. After buying your supplies you get to decide your recipe and start making money.\n\n There are a couple of things that affect the way your customers will buy. The first thing is the weather. If the weather is hot and sunny more customers will be willing to buy your lemonade than if it was cold and storming. The next thing that will affect your game is your recipe, try switching it up to see what your customers like.\n\n After each day your total profit or loss will be displayed. The goal is to make as much money possible. Good luck!\n\n Press enter to continue.");
        //               MainMenu();
        //               break;
        //           case "shop":
        //               store.StoreStart(player);
        //               break;
        //           case "make":
        //               recipe.RecipeStart(player);
        //               break;
        //           case "check":
        //              player.inventory.DisplayInventory();

        //               break;

        //           default:
        //               Console.WriteLine("User error, please type one of the options given.");
        //               Console.ReadKey();
        //               Console.Clear();
        //               MainMenu();
        //               break;
        //       }
        //       return userInput;
        //   }
    }
}
