using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using rankingcandidatos.API.Dominio;

namespace rankingcandidatos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatosController : ControllerBase
    {
        [HttpGet]
        public List<string> ListarCandidatos()
        {
            var candidatos = new List<string>();

            candidatos.Add("Pedro");
            candidatos.Add("Fernando");

            return candidatos;
        }
        
        [HttpPost]
        public Candidato Cadastrar([FromBody] Candidato c)
        {
            
            
            return c;
        }
    }
}