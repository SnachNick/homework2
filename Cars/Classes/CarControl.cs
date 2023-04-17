using System;
using System.Runtime.ConstrainedExecution;

namespace NCars.Classes
{
    public class CarControl:ICar
    {
        public static readonly Cars car1 = new Cars("Rivian", "R1T"," - ", "Electric", "Automatic Transmission", "2023/01");
        public static readonly Cars car2 = new Cars("Tesla", "Model Y"," - ", "Electric", "Automatic Transmission", "2021/12");
        public static readonly Cars car3 = new Cars("VW", "Taureg","1.6", "Disel", "Automatic Transmission", "2019/01");
        public static readonly Cars car4 = new Cars("Pontiac", "Solstice","3.5", "Gas", "Automatic Transmission", "2008/03");
        public static readonly Cars car5 = new Cars("ZAZ", "Tavria", "1.3", "Gas", "Manual Transmission", "2005/01");
        public static readonly Cars car6 = new Cars("Toyota", "Camry", "3.5", "Gas", "Automatic Transmission", "2017/04");
        public static readonly Cars car7 = new Cars("Ford", "Shelby GT-H", "5.0", "Gas", "Automatic Transmission", "2007/05");
        private static readonly Cars car8 = new Cars("Nissan", "GT-R", "3.5", "Gas", "Automatic Transmission", "2008/08");
        public List<Cars> cars { get; set; }
        public IEnumerable<string> GetCarNameL()
        {
            var scars = from c in cars
                        orderby c.Maker
                        select "Maker " + c.Maker + " Model " + c.Model;
            return scars;
        }

        public IEnumerable<string> GetCarEngineL()
        {
            var scars = from c in cars
                        orderby c.Maker
                        select "Maker" +  c.Maker + " Model " + c.Model + " Engine: "+c.Engine;
            return scars;
        }

        public IEnumerable<string> GetCarAgeL()
        {
            var scars = from c in cars
                        orderby c.Maker
                        select "Maker " + c.Maker + " Model " + c.Model + " " + (DateTime.Now.Year - Int32.Parse(c.ProdDate.Substring(0,4))) + " years old";
            return scars;
        }

        public string GetCarName()
        {
            throw new NotImplementedException();
        }

        public CarControl()
        {
            cars = new List<Cars>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            cars.Add(car7);
            cars.Add(car8);
        }
        
    }
}
