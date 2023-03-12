namespace HomeWork3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sA;
            int a,sum = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Input any number:");
            Console.ResetColor();
            sA = Console.ReadLine();
            for (int i = 0; i < sA.Length; ++i)
            {
                if (int.TryParse(sA.Substring(i,1), out a))
                {
                    sum = sum + a;  
                }
            }
            Console.WriteLine($"Sum of numbers: \n {sum}");
            Console.Write("Press enter to continue");
            Console.ReadLine();

        }
    }
}