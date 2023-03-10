using System.Numerics;
using System.Xml.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string sA;
            Decimal Dc;

            //-- print the result of the specified operations 
            c = -1 + (4 * 6);
            Console.WriteLine($"The result of (-1+4*6) is {c}");
            Console.WriteLine();
            Dc = (35 + 5) % 7;
            Console.WriteLine($"The result of ((35 + 5) % 7) is {Dc}");
            Console.WriteLine();
            Dc = 14 + (-4 * 6) / 11;
            Console.WriteLine($"The result of (14 + -4 * 6 / 11) is {Dc}");
            Console.WriteLine();
            Dc = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"The result of (2 + 15 / 6 * 1 - 7 % 2) is {Dc}");
            Console.WriteLine();
            Console.WriteLine();

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
                    //--print the sum of two numbers
                    Console.WriteLine($"The sum of those two numbers is {a + b}");
                    //--print the result of dividing two numbers
                    if (b != 0)
                    {
                        Dc = (a / b);
                        Console.WriteLine($"The result of dividing those two numbers is {Math.Round(Dc, 2)}");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("You can't devide by 0.");
                        Console.ResetColor();
                    }
                    //--print the result of swapping two numbers
                    (a, b) = (b, a);
                    Console.WriteLine($"The result of swapping \nFirst Number : {a} \nSecond  Number : {b} ");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Type third number");
                    Console.ResetColor();
                    sA = Console.ReadLine();
                    if (int.TryParse(sA, out c))
                    {
                        Console.WriteLine($"The multiply of those three numbers is {a * b * c}");
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