using System.Collections.Generic;
using rankingcandidatos.API.Dominio;

namespace rankingcandidatos.API.Infra.Dados
{
    public interface ICandidatoRepositório
    {
        List<Candidato> ListarCandidatos();
        Candidato CriarCandidato(Candidato candidato);
    }
}