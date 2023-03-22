using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Students("Alex", "Pereverzev", "Brovary", new DateTime(1984, 07, 24));
            var students1 = new Students("test", "test", "Brovary", new DateTime(1984, 07, 24));

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
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public string City { get; set; }
        private Cources[] _cources = Array.Empty<Cources>();
        public Cources[] Cources
        {
            get { return this._cources; }
            set { this._cources = value; }
        }

        public Students(string firstName, string lastName, string city, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Birthday = birthday;

        }
        public Students(string firstName, string lastName, string city, DateTime birthday, Cources[] cources)
        {
            _cources = cources;
            Cources = cources;
        }

        public void AddCource(Cources cource)
        {
            Cources[] t = Cources;

            if (Cources.Length == 0)
            {
                Cources = new Cources[1] { cource };
                cource.AddStudent();
            }
            else
            {
                Array.Resize(ref t, Cources.Length + 1);
                t[Cources.Length] = cource;
                Cources = t;
                cource.AddStudent();

            }


        }

        public void RemoveCource(Cources cource)
        {
            int index = Array.IndexOf(Cources, cource);
            Cources = Cources.Where((e, i) => i != index).ToArray();
            cource.DecStudent();
        }


        public void Print()
        {
            Console.WriteLine($"First name is {FirstName}, Last Name is {LastName}, from City {City}, {(DateTime.Now.Year - Birthday.Year)} years old");
            foreach (var item in Cources)
            {
                item.Print();
            }
        }

    }

    

}

