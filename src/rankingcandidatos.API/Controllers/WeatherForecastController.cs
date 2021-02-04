using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rankingcandidatos.API.Dominio;
using rankingcandidatos.API.Infra.Dados;

namespace rankingcandidatos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICandidatoRepositório _candidatoRepositório;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICandidatoRepositório candidatoRepositório)
        {
            _logger = logger;
            _candidatoRepositório = candidatoRepositório;
            _candidatoRepositório.CriarCandidato(new Candidato
            {
                Nome = "Lula",
                Número = 13
            });
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
    }
}
