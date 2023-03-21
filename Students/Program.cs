using System;
using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Students("Alex", "Pereverzev", "Brovary", new DateTime(1984, 07, 24), "C# part 1");
            students.Print();
                        
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public string City { get; set; }
        public string Cource { get; set; }
        public string []Cources { get; private  set; }
        public Students(string firstName, string lastName, string city, DateTime birthday, string cource)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Birthday = birthday;
            Cource = cource;
            string[] cources1;
            Cources = new string[]Append(Cource);
        }
        public void AddCource(string cource)
        {
            Cources = Cources.Append(cource).ToArray();
        }
        public void RemoveCource(string cource)
        {
            Cources = Cources.Except(new string[] { cource }).ToArray();
        }

        public void Print()
        {
            Console.WriteLine($"First name is {FirstName}, Last Name is {LastName}, from City {City}, {(DateTime.Now.Year - Birthday.Year)} , cources {string.Join(string.Empty, Cources)}");
        }

    }

    class Course 
    {
        public string CoursetName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public DateTime CourceStarDate { get; set; }
        public int CourceDuration { get; set; }
        public int CourceStudentsCount { get; set; }
        public Course(string courseName, string firstName, string lastName, DateTime courceStarDate, int courceDuration, int courceStudentsCount)
        {
            CoursetName = courseName;
            TeacherFirstName = firstName;
            TeacherLastName = lastName;
            CourceStarDate = courceStarDate;
            CourceDuration = courceDuration;
            CourceStudentsCount = courceStudentsCount;

        }
        public void Print()
        {
            Console.WriteLine($"Course name is {CoursetName}, a teacher name is {TeacherFirstName}{TeacherLastName}. The course is starting at {CourceStarDate} and ending {CourceStarDate.AddDays(CourceDuration)}, number of students is {CourceStudentsCount} ");
        }

    }

}

