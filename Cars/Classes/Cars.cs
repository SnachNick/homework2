namespace NCars.Classes
{
    public class Cars
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Fuel_Type { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string ProdDate { get; set; }
        public int Rate { get; set; }
        public Cars(string maker, string model, string engine, string fuel_type, string transmission, string proddate)
        {
            Maker = maker;
            Model = model;
            Engine = engine;
            Fuel_Type = fuel_type;
            Transmission = transmission;
            ProdDate = proddate;
        }

        //public string GetCarName() => "test";


    }
}
