using System.Numerics;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sA;
            int a, b;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Input first integer:");
            Console.ResetColor();
            sA = Console.ReadLine();
            if (int.TryParse(sA, out a))
            {
                Console.WriteLine("Input second integer:");
                Console.ResetColor();
                sA = Console.ReadLine();
                if (int.TryParse(sA, out b))
                {
                    if ((a < 0) || (b < 0))
                    {
                        Console.WriteLine($"Check if one is negative and one is positive: \n True");
                    }
                    else
                    {
                        Console.WriteLine($"Check if one is negative and one is positive: \n False");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Not an integer, please try again.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Not an integer, please try again.");
            }
            Console.ResetColor();
            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
    }
}