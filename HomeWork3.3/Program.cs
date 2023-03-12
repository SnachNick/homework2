using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.IO;

namespace HomeWork3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            bool flag = false;
            //- Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            //- Write a C# program to compute the sum of the first 500 prime numbers.
            for (int i = 2, t = 0; t < 500; ++i)
            {
                flag = true;
                for (int a = 2; a <= Math.Ceiling(Math.Sqrt(i)); ++a)
                {
                    if (i % a == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (i == 2 | flag )
                {
                    ++t;
                    sum = sum + i;
                }
            }
            Console.WriteLine($"Sum of the first 500 prime numbers: \n {sum}");
            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
    }
}