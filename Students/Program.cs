using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Students("Alex", "Pereverzev", "Brovary","Kiev", new DateTime(1984, 07, 24));
            var students1 = new Students("test", "test", "Brovary", "Kiev", new DateTime(1984, 07, 24));

            var cources1 = new Cources("C#", "Kristina", "Hurieieva", new DateTime(2023, 03, 08), 4, 10);
            var cources2 = new Cources("C#", "test", "test", new DateTime(2023, 03, 08), 4, 10);

            students.Print();
            cources1.Print();
            students.AddCource(cources1);
            students1.AddCource(cources1);
            students.AddCource(cources2);
            students.Print();
            students.RemoveCource(cources1);
            students.Print();

            students.GetInfo();

        }
    }
}

