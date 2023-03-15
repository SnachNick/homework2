using System;
using System.ComponentModel;

namespace homework_4_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string sA;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type first number");
            Console.ResetColor();

            sA = Console.ReadLine();
            if (int.TryParse(sA, out a))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Type second number");
                Console.ResetColor();
                sA = Console.ReadLine();
                if (int.TryParse(sA, out b))
                {
                    
                    //Write a C# program to check two given integers and return true if one is negative and one is positive.
  
                    if (Math.Abs(a) != a)
                    {
                        sA = $"one of those two numbers {a.ToString()} is negative";
                    }
                    else
                    {
                        sA = $"one of those two numbers {a.ToString()} is positive";
                    };
                    if (Math.Abs(b) != b)
                    {
                        sA = sA + $" and another one {b.ToString()} is negative";
                    }
                    else
                    {
                        sA = sA + $" and another one {b.ToString()} is positive";
                    };

                    Console.WriteLine($"The result is {((a > 0 & b < 0) | (a < 0 & b > 0))} {sA}");

                    //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

                    if (a == 20 | b == 20 | (a + b) == 20)
                    {
                        Console.WriteLine($"The result is {(a == 20 | b == 20 | (a + b) == 20)} one of the numbers is 20 or their sum is 20");
                    }
                    else
                    {
                        Console.WriteLine($"The result is {(a == 20 | b == 20 | (a + b) == 20)} no one of the numbers is 20 and their sum is not 20");
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