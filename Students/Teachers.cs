namespace Students
{
    class Teachers : Persons
    {
        public Teachers(string firstName, string lastName, string city, string region, DateTime birthday) : base(firstName, lastName, city, region, birthday)
        {
        }
        public override int GetInfo()
        {
            Console.WriteLine($"The teacher First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region, age is {(DateTime.Now.Year - Birthday.Year)}");
            return 0;
        }
    }
}