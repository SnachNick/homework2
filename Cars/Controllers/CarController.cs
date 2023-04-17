using NCars.Classes;
using Microsoft.AspNetCore.Mvc;

namespace NCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
/*
        private static readonly Cars car1 = new Cars("Rivian", "R1T", "Electric", "Automatic Transmission", "2023/01");
        private static readonly Cars car2 = new Cars("Tesla", "Model Y", "Electric", "Automatic Transmission", "2021/12");
        private static readonly Cars car3 = new Cars("VW", "Taureg", "Disel", "Automatic Transmission", "2019/01");
        private static readonly Cars car4 = new Cars("Pontiac", "Solstice", "Gas", "Automatic Transmission", "2008/03");
        private static readonly Cars car5 = new Cars("ZAZ", "Tavria", "Gas", "Manual Transmission", "2005/01");
        private static readonly Cars car6 = new Cars("Toyota", "Camry", "Gas", "Automatic Transmission", "2017/04");
        private static readonly Cars car7 = new Cars("Ford", "Shelby GT-H", "Gas", "Automatic Transmission", "2007/05");
        private static readonly Cars car8 = new Cars("Nissan", "GT-R", "Gas", "Automatic Transmission", "2008/08");
*/
/*
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Cars> Get()
        {
            
            
            var car = new List<Cars>();
           /* car.Add(car1); 
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
    */
    }
}