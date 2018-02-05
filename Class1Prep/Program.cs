using System;

namespace Class1PrepName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
