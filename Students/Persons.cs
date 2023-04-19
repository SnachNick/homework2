namespace Students
{
    class Persons 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public DateTime Birthday { get; private set; }

        public Persons(string firstName, string lastName, string city, string region, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Region = region;
            Birthday = birthday;
        }
        public Persons(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Persons() { }    
        public virtual int GetInfo()
        {
            Console.WriteLine($"First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region  {(DateTime.Now.Year - Birthday.Year)} years old");
            return 0;
        }
        public void GetPersonInfo(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine($"The teacher First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region  {(DateTime.Now.Year - Birthday.Year)} years old");
                    break;
                case 2:
                    Console.WriteLine($"The student First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region  {(DateTime.Now.Year - Birthday.Year)} years old");
                    break;
            }
        }
    }
}