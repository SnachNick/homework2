﻿using System.Collections.ObjectModel;

namespace Students
{
    class Cources
    {
        public string CoursetName { get; set; }
        public DateTime CourceStarDate { get; set; }
        public int CourceDuration { get; set; }
        public int CourceStudentsCount { get; set; }
        public int CourceInvitedStudents { get; private set; }

        public Collection<Students> _student = new Collection<Students>();
        public Collection<Students> Students
        {
            get { return this._student; }
            set { this._student = value; }
        }

        public Cources(string courseName, DateTime courceStarDate, int courceDuration, int courceStudentsCount)
        {
            CoursetName = courseName;
            CourceStarDate = courceStarDate;
            CourceDuration = courceDuration;
            CourceStudentsCount = courceStudentsCount;
        }
        public void Print()
        {
            Console.WriteLine($"Course name is {CoursetName}. The course is starting at {CourceStarDate.ToString("MM/dd/yyyy")} and ending {CourceStarDate.AddDays(CourceDuration).ToString("MM/dd/yyyy")}, max number of students is {CourceStudentsCount}, invited number of students is {CourceInvitedStudents}");
        }

        public void AddStudent(Students student)
        {
            try
            {
                Students.Add(student);
                CourceInvitedStudents++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        public void DecStudent(Students student)
        {
            try
            {
                Students.Remove(student);
                CourceInvitedStudents--;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}