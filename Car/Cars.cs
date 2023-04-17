namespace NewCars
{
    public class Cars : ICar
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Fuel_Type { get; set; }
        public string Transmission { get; set; }
        public string ProdDate { get; set; }
        public Cars(string maker, string model, string fuel_type, string transmission, string proddate)
        {
            Maker = maker;
            Model = model;
            Fuel_Type = fuel_type;
            Transmission = transmission;
            ProdDate = proddate;
        }

        public string GetCarName() => "Test";
  /*      public string GetCarEngine() => Model;
        public string GetCarAge() => ProdDate;
*/    }
}
