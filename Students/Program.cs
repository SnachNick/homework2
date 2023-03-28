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

            var cources1 = new Cources("C#", new DateTime(2023, 03, 08), 4, 10);
            var cources2 = new Cources("C#2", new DateTime(2023, 03, 08), 4, 10);

            var teacher1 = new Teachers("Kristina", "Hurieieva", "Kiev", "Kiev", new DateTime(1990, 03, 08));
            var teacher2 = new Teachers("test", "test", "Brovary", "Kiev", new DateTime(1984, 03, 08));

           // string firstName, string lastName, string city, string region, DateTime birthday

            //, "test", "test"
            //, "Kristina", "Hurieieva"
           // students.Print();
            //cources1.Print();
            students.AddCource(cources1);
            students1.AddCource(cources1);
            students.AddCource(cources2);
           // students.Print();
            students.RemoveCource(cources1);
            //students.Print();
            
            cources1.AddStudent(students);
            cources2.AddStudent(students1);

            //students.GetInfo();

            teacher1.AddCource(cources2);
            teacher1.GetInfo();
            teacher1.RemoveCource(cources2);
            teacher1.GetInfo();

            teacher2.GetInfo();
            teacher2.AddCource(cources1);


            cources1.AddStudent(students);
            cources2.AddStudent(students1);

            students.GetInfo();


        }
    }
}

