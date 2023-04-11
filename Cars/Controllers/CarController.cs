using Microsoft.AspNetCore.Mvc;
using System;

namespace Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {

        private static readonly Car car1 = new Car("Rivian", "R1T", "Electric", "Automatic Transmission", "2023/01");
        private static readonly Car car2 = new Car("Tesla", "Model Y", "Electric", "Automatic Transmission", "2021/12");
        private static readonly Car car3 = new Car("VW", "Taureg", "Disel", "Automatic Transmission", "2019/01");
        private static readonly Car car4 = new Car("Pontiac", "Solstice", "Gas", "Automatic Transmission", "2008/03");
        private static readonly Car car5 = new Car("ZAZ", "Tavria", "Gas", "Manual Transmission", "2005/01");
        private static readonly Car car6 = new Car("Toyota", "Camry", "Gas", "Automatic Transmission", "2017/04");
        private static readonly Car car7 = new Car("Ford", "Shelby GT-H", "Gas", "Automatic Transmission", "2007/05");
        private static readonly Car car8 = new Car("Nissan", "GT-R", "Gas", "Automatic Transmission", "2008/08");


        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> Get()
        {
            
            
            var car = new List<Car>();
            car.Add(car1); 
            car.Add(car2);
            car.Add(car3);
            car.Add(car4);
            car.Add(car5);
            car.Add(car6);
            car.Add(car7);
            car.Add(car8);

            var random = new Random();
            foreach (var c in car)
                c.Rate = random.Next(1, 8);

            var scars = from c in car
                                orderby c.Rate
                        select c;
            return scars;
        }
    }
}