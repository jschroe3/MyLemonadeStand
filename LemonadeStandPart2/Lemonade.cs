using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandPart2
{
    public class Lemonade
    {
        private int lemonSupply;
        private int iceSupply;
        private int sugarSupply;
        private double costperCup;

        public int LemonSupply { get { return lemonSupply; } }
        public int IceSupply { get { return iceSupply; } }
        public int SugarSupply { get { return sugarSupply; } }
        public double PricePerCup { get { return costperCup; } set { costperCup = value; } }

        public Lemonade()
        {
            costperCup = 2.00;
            GetRecipe();
            SetLemonadePrice();
        }

        public void GetRecipe()
        {
            GetLemonAmount();
            GetSugarAmount();
            GetIceAmount();
            DisplayRecipe();
        }

        private void GetLemonAmount()
        {
            Console.WriteLine("How many lemons should be in each glass? Enter the amount: ");
            lemonSupply = int.Parse(Console.ReadLine());
        }

        private void GetSugarAmount()
        {
            Console.WriteLine("How much sugar should be in each glass? Enter the amount: ");
            sugarSupply = int.Parse(Console.ReadLine());
        }

        private void GetIceAmount()
        {
            Console.WriteLine("How many ice cubes should be in each glass? Enter the amount: ");
            iceSupply = int.Parse(Console.ReadLine());
        }

        private void DisplayRecipe()
        {
            Console.WriteLine();
            Console.WriteLine("Ingredients per cup of Lemonade: ");
            Console.WriteLine($"Lemons: {lemonSupply}");
            Console.WriteLine($"Sugar: {sugarSupply}");
            Console.WriteLine($"Ice: {iceSupply}");
            Console.WriteLine();
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine($"Default price per cup of lemonade: ${costperCup}");
            Console.WriteLine("Would you like to change this price? Enter 'yes' or 'no'.");
            string alter = Console.ReadLine().ToLower();

            if (alter == "yes")
            {
                Console.WriteLine("Enter the amount you want to charge for each cup: ");
                costperCup = double.Parse(Console.ReadLine());
            }
            else if (alter == "no")
            {
                costperCup = 2.00;
            }
            else if (alter != "yes" && alter != "no")
            {
                Console.WriteLine("You did not enter a valid response. Please enter only 'yes' or 'no' as a response.");
                Console.WriteLine();
                SetLemonadePrice();
            }
        }
    }
}
