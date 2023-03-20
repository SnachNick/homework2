using System.ComponentModel;

namespace homework_4_1
{
    internal class MyProgram
    {
        public void MxVle(int a, int b, int c, out string val)
        {
            int [] nums = { a, b, c };
            int max = nums[0];
            int min = max;
            int sum = max;
            for (int i = 1; i < nums.Length; ++i)
            {
                //Write a C# method to find the largest value from three integer values.
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                //Write a C# method to find the lowest value from three integer values.
                if (nums[i] < min) {
                    min = nums[i];
                }
                //Write a C# method to compute the sum of all the elements of an array of integers
                sum += nums[i];
            }
            val = $"Max value is {max} min value is {min} the the sum of all the elements of an array is {sum}";
        }
        public void NearValue(int a, int b, out string val)
        {
            //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
            if (a == b)
                {
                val = "Two numbers are same result = 0";
                }
            else if (Math.Abs(a - 20) < Math.Abs(b - 20))
            {
                val = $"The first value {a} is nearest to 20 than second {b}" ;

            }
            else
                val = $"The second value {b} is nearest to 20 than the first {a}";
        }
        static void Main(string[] args)
        {
            int a, b, c;
            string sA;
            MyProgram n = new MyProgram();
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
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Type third number");
                        Console.ResetColor();
                        sA = Console.ReadLine();
                    if (int.TryParse(sA, out c))
                    {
                        n.MxVle(a, b, c, out sA);
                        Console.WriteLine(sA);
                        n.NearValue(a, b, out sA);
                        Console.WriteLine(sA);
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