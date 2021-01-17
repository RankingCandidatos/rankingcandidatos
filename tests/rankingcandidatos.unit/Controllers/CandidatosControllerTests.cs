using System.Collections.Generic;
using NUnit.Framework;
using rankingcandidatos.API.Controllers;
using rankingcandidatos.API.Dominio;

namespace rankingcandidatos.unit.Controllers
{
    public class CandidatosControllerTests
    {
        [Test]
        public void ListarCandidatosDevRetornarListaDeCandidatos()
        {
            var controller = new CandidatosController();
            var lista = controller.ListarCandidatos();

            List<string> listaEsperada = new List<string>();
            listaEsperada.Add("Pedro");
            listaEsperada.Add("Fernando");
            Assert.AreEqual(lista, listaEsperada);


        }

        [Test]
        public void CadastrarDevRetornarOCandidatoCadastrado()
        {
            var controller = new CandidatosController();
            Candidato novoCandidato = new Candidato{Nome = "Pedro", Numero = 1};
            var candidato = controller.Cadastrar(novoCandidato);

            Assert.AreEqual(candidato, novoCandidato);
        }
    }
}