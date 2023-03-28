using System.Collections.ObjectModel;

namespace Students
{
    class Students : Persons
    {
        //private Cources[] _cources = Array.Empty<Cources>();

        private Collection<Cources> _cources = new Collection<Cources>();
        public Collection<Cources> Cources
        {
            get { return this._cources; }
            set { this._cources = value; }
        }

        public Students(string firstName, string lastName, string city, string region, DateTime birthday) : base (firstName, lastName, city, region, birthday)
        {
        }
        public Students(Collection<Cources> cources)
        {
            _cources = cources;
            Cources = cources;
        }

        public void AddCource(Cources cource)
        {
            Cources.Add(cource);
        }

        public void RemoveCource(Cources cource)
        {
            Cources.Remove(cource); 
        }
        public override int GetInfo()
        {
            Console.WriteLine($"The student First name is {FirstName}, Last Name is {LastName}, from City {City}, in the {Region} region, age is  {(DateTime.Now.Year - Birthday.Year)}");

            foreach (var item in Cources)
            {
                item.Print();
            }
            return 0;
        }

        public void Print()
        {
            
            foreach (var item in Cources)
            {
                item.Print();
            }
        }

    }

    

}

