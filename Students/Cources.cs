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
        public int CourceInvitedStudents { get; private set; }
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
            Console.WriteLine($"Course name is {CoursetName}, a teacher name is {TeacherFirstName}{TeacherLastName}. The course is starting at {CourceStarDate.ToString("MM/dd/yyyy")} and ending {CourceStarDate.AddDays(CourceDuration).ToString("MM/dd/yyyy")}, max number of students is {CourceStudentsCount}, invited number of students is {CourceInvitedStudents}");
        }
        public void AddStudent()
            {
            CourceInvitedStudents++;
            }
        public void DecStudent()
        {
            if (CourceInvitedStudents>0)
            CourceInvitedStudents --;
        }

    }
}