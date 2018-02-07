using System;

namespace Class1NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are the dimensions of the rectangle that you'd like to calculate?:");

            Console.WriteLine("What is the length of the rectangle?:");
            string len = Console.ReadLine();
            double length = double.Parse(len);

            Console.WriteLine("What is the width of the rectangle?:");
            string wid = Console.ReadLine();
            double width = double.Parse(wid);

            double area = length * width;
            Console.WriteLine("The area of your rectangle is " + area);
            Console.ReadLine();
        }
    }
}



//Last console writeline, concat, better way $"Mystring{variablename}" - similar to stringbuilder
//string builder is with files and etc. not neccessarily for this class.