namespace Cars
{
    public class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Fuel_Type { get; set; }
        public string Transmission { get; set; }
        public string ProdDate { get; set; }
        public int Rate{get; set; }
        public Car(string maker, string model, string fuel_type, string transmission, string proddate)
        {
            Maker = maker;
            Model = model;
            Fuel_Type = fuel_type;
            Transmission = transmission;
            ProdDate = proddate;
        }
    }
}
