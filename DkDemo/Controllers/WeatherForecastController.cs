using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DkDemo.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DkDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string WechatCheck(string signature, string timestamp, string nonce, string echostr)
        {
            return CheckWechatMsg.Action(signature, timestamp, nonce, echostr);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public WPluse Post(WRequest wRequest)
        {
            var rng = new Random();
            var model = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                userType = (UserType)(new Random().Next(0, 4))
            })
            .ToArray();
            WPluse wPluse = new WPluse()
            {
                msg = model.ToList(),
                Pwd = wRequest.Pwd,
                Name = wRequest.Name
            };
            return wPluse;
        }
    }
}
