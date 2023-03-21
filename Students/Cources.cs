namespace Students
{
    class Cources
    {
        public string CoursetName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public DateTime CourceStarDate { get; set; }
        public int CourceDuration { get; set; }
        public int CourceStudentsCount { get; set; }

        public Cources(string courseName, string firstName, string lastName, DateTime courceStarDate, int courceDuration, int courceStudentsCount)
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
            Console.WriteLine($"Course name is {CoursetName}, a teacher name is {TeacherFirstName}{TeacherLastName}. The course is starting at {CourceStarDate.ToString("MM/dd/yyyy")} and ending {CourceStarDate.AddDays(CourceDuration).ToString("MM/dd/yyyy")}, number of students is {CourceStudentsCount} ");
        }

    }
}