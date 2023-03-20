using System.Linq;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public string City { get; set; }
        public string[] Cources { get; set; }

        public void AddStudent(string firstName, string lastName, string city, DateTime birthday, string cource)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Birthday = birthday;
            Cources = Cources.Append(cource).ToArray();

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
            Console.WriteLine($"First name is {FirstName}, Last Name is {LastName}, from City {City}, {(DateTime.Now.Year - Birthday.Year)} ");
        }

    }

    class Courses
    {
        public string CoursetName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public DateTime Birthday { get; set; }

        public string City { get; set; }
        public string[] Cources { get; set; }

        public void AddStudent(string firstName, string lastName, string city, DateTime birthday, string cource)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Birthday = birthday;
            Cources = Cources.Append(cource).ToArray();

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
            Console.WriteLine($"First name is {FirstName}, Last Name is {LastName}, from City {City}, {(DateTime.Now.Year - Birthday.Year)} ");
        }
    }

        Create a course class and describe its main characteristics: course name, teacher name, course duration, number of students.

}

