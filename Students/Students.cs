namespace Students
{
    class Students : Persons
    {
        private Cources[] _cources = Array.Empty<Cources>();
        public Cources[] Cources
        {
            get { return this._cources; }
            set { this._cources = value; }
        }

        public Students(string firstName, string lastName, string city, string region, DateTime birthday) : base (firstName, lastName, city, region, birthday)
        {
        }
        public Students(Cources[] cources)
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

