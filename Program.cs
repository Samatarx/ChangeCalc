using System;

namespace ChangeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            // Ask the user for their name and number
            Console.WriteLine("How much money would you like to convert?");
            string money = Console.ReadLine();
            double amount = Math.Ceiling(Convert.ToDouble(money));
            Console.WriteLine($"{amount} cents is equal to");
            //  Define variables
            int gold = 10;
            int silver = 5;
            //  Maximum number of gold
            double goldCoins = Math.Floor(amount / gold);
            double goldChange = amount % gold;
            //  Max number of silver
            double silverCoins = Math.Floor(goldChange / silver);
            //  Bronze change
            double silverChange = goldChange % silver;
            double remainder = silverChange % silver;
            // Print coins
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
