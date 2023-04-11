using System;
using System.Collections.ObjectModel;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Students("Alex", "Pereverzev", "Brovary", "Kiev", new DateTime(1984, 07, 24));
            var student1 = new Students("Nika", "Pereverzeva", "Brovary", "Kiev", new DateTime(2009, 03, 08));
            var student2 = new Students("Helen", "Pereverzeva", "Brovary", "Kiev", new DateTime(1985, 04, 20));
            var student3 = new Students("Slava", "Dolot", "Kiev", "Kiev", new DateTime(1872, 06, 24));
            var student4 = new Students("Andrii", "Gulak", "Brovary", "Kiev", new DateTime(1984, 11, 09));

            var cources1 = new Cources("C#", new DateTime(2023, 03, 08), 4, 10);
            var cources2 = new Cources("SAP HANA", new DateTime(2023, 04, 08), 4, 10);
            var cources3 = new Cources("Azure DF", new DateTime(2023, 05, 08), 4, 10);

            var teacher1 = new Teachers("Kristina", "Hurieieva", "Kiev", "Kiev", new DateTime(1990, 03, 08));
            var teacher2 = new Teachers("Serhii", "Shepelev", "Kiev", "Kiev", new DateTime(1980, 03, 08));
            var teacher3 = new Teachers("Artem", "Siedin", "Donetsk", "Donetsk", new DateTime(1980, 04, 08));

            student.AddCource(cources1);
            student.AddCource(cources3);
            student1.AddCource(cources1);
            student2.AddCource(cources1);
            student2.AddCource(cources2);
            student2.AddCource(cources3);
            student3.AddCource(cources2);
            student4.AddCource(cources1);

            teacher1.AddCource(cources2);
            teacher2.AddCource(cources1);
            teacher3.AddCource(cources3);


            var students = new List<Students>() {
                student,
                student1, 
                student2, 
                student3, 
                student4
            };

            var teachers = new List<Teachers>() {
                teacher1,
                teacher2,
                teacher3
            };

            var cources = new List<Cources>() {
                cources1,
                cources2,
                cources3
            };

            foreach( var st in students)
            {
                Console.WriteLine($"Student {st.FirstName}, {st.LastName}");
                Console.WriteLine("Courses of the student:");
                foreach(var c in st._cources)
                {
                    Console.WriteLine($"Course of {c.CoursetName}");
                }
                Console.WriteLine("--------------------------------------------");
            };

            foreach (var tc in teachers)
            {
                Console.WriteLine($"Teacher {tc.FirstName}, {tc.LastName}");
                Console.WriteLine("Courses of the teacher:");
                foreach (var c in tc._cources)
                {
                    Console.WriteLine($"Course of {c.CoursetName}");
                }
                Console.WriteLine("--------------------------------------------");
            };

            foreach (var c in cources)
            {

                var tLq = from t in teachers where t.Cources.Contains(c) select t.LastName + " " + t.FirstName;
                foreach (var t in tLq) 
                {
                    Console.WriteLine($"Cource Name  is {c.CoursetName}.Teacher name is {t} Invited students:");
                    var stLq = from Studentsstudent in students where Studentsstudent.Cources.Contains(c) select Studentsstudent.LastName + " " + Studentsstudent.FirstName;
                    foreach (var s in stLq)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("--------------------------------------------");
                }
            }
            Console.WriteLine("Please enter the name for searching through all objects:");
            var search = Console.ReadLine();
            var tcc = from t in teachers where t.FirstName.Contains(search) select t.LastName + " " + t.FirstName;
            foreach (var t in tcc)
            {
                Console.WriteLine($"Teacher name is {t}.");
                
            }
            Console.WriteLine("--------------------------------------------");
            var tt = from t in cources where t.CoursetName.Contains(search) select t.CoursetName;
            foreach (var t in tt)
            {
                Console.WriteLine($"Cource Name  is {t}.");

            }
            Console.WriteLine("--------------------------------------------");
            var ts = from t in students where t.FirstName.Contains(search) select t.LastName + " " + t.FirstName;
            foreach (var t in tt)
            {
                Console.WriteLine($"Student Name  is {t}.");

            }
            Console.WriteLine("--------------------------------------------");

        }
    }
}

