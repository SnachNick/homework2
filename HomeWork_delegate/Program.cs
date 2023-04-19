namespace HomeWork_delegate
{
    internal class Program
    {
        public delegate void MyFirstDelegate(string mess);
        static void Main(string[] args)
        {
            string test = "test";
            var del1  = new MyFirstDelegate(SecondPrint);
            del1(test);
            testdelparem(del1);
            del1 = new MyFirstDelegate(FirstPrint);
            del1(test);
            testdelparem(del1);
        }
        static void testdelparem(MyFirstDelegate del)
        {
            string newtext = "was printed from another method as well";
            del(newtext);
        }
        static void SecondPrint(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Here is the red method {text}");
            Console.ResetColor();
        }
        static void FirstPrint(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Here is the blue method {text}");
            Console.ResetColor();
        }
    }
}