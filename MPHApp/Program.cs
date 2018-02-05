using System;
//using System.String;

namespace MPHApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?: ");
            string miInput = Console.ReadLine();
            decimal miles = decimal.Parse(miInput);

            Console.WriteLine("How much gas have you consumed (in gallons)?: ");
            string galInput = Console.ReadLine();
            decimal gallon = decimal.Parse(galInput);

            decimal mph = miles / gallon;
           // mph = string decimal ToString("0.00");
            Console.WriteLine("Your miles per gallon is " + mph.ToString("0.00"));

            Console.ReadLine();


        }
    }
}
