using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace counter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static int Counter = 0;

        [HttpGet]
        public int Get()
        {
            return Counter;
        }

        [HttpPost("decrease")]
        public void Decrease(int amount)
        {
            Counter = Counter - amount;
        }

        [HttpPost("increase")]
        public void Increase(int amount)
        {
            Counter = Counter + amount;
        }


        [HttpPost("reset")]
        public void Reset(int amount)
        {
            Counter = 0;
        }
    }
}
