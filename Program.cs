using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins?");
            string money = Console.ReadLine();
            double moneyi = Convert.ToDouble(money);
            // let the user know howmuch he insert
            Console.WriteLine($"{moneyi} is equal to...");

            // convert to coins.

            double gold = 10;
            double silver = 5;

            //checking howmany gold coins fit
            double goldCoins = Math.Round(moneyi / gold);
            //checks howmuch  is left from the total money.
            double remainder = moneyi % gold;

            //Checking howmany silver coins fit in the left overs

            double silverCoins = Math.Round(remainder / silver);
            remainder = remainder % silver;

            //Print everything to the console

            Console.WriteLine($"Gold Coins = {goldCoins}");
            Console.WriteLine($"Silver Coins = {silverCoins}");
            Console.WriteLine($"Bronze Coins = {remainder}");


        }
    }
}
