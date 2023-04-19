using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
    
        public delegate void delRed(string text);
        //Create delegate printString and use it  to reference method that takes a string as input and returns nothing.
        static void SecondPrint(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Here is the red method {text}");
            Console.ResetColor();
        }
    }
}
