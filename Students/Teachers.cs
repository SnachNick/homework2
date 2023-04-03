using System.Collections.ObjectModel;

namespace Students
{
    class Teachers : Persons
    {
        private Collection<Students> _student = new Collection<Students>();
        public Collection<Students> Students
        {
            get { return this._student; }
            set { this._student = value; }
        }
        public Collection<Cources> _cources = new Collection<Cources>();
        public Collection<Cources> Cources
        {
            get { return this._cources; }
            set { this._cources = value; }
        }
        public Teachers(string firstName, string lastName, string city, string region, DateTime birthday) : base(firstName, lastName, city, region, birthday)
        {
        }
        public override int GetInfo()
        {
            Console.WriteLine($"The teacher First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region, age is {(DateTime.Now.Year - Birthday.Year)}");
            foreach (var student in this.Students)
            {
                student.Print();
            }
            foreach(var cource in this.Cources)
            {
                cource.Print();
            }

            return 0;
        }
        public void AddCource(Cources cource)
        {
            try
            {
                Cources.Add(cource);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveCource(Cources cource)
        {
            try
            {
                Cources.Remove(cource);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddStudent(Students student)
        {
            try
            {
                Students.Add(student);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}