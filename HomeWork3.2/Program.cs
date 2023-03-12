namespace HomeWork3._2
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
                    if (((a + b) == 20) | (b == 20) | (a == 20))
                    {
                        Console.WriteLine($"One of given numbers = 20 or their sum = 20");
                    }
                    else
                    {
                        Console.WriteLine($"Not one of given numbers = 20 or their sum != 20");
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