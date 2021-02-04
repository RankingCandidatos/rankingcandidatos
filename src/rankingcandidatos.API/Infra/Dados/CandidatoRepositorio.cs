using System.Collections.Generic;
using MongoDB.Driver;
using rankingcandidatos.API.Dominio;

namespace rankingcandidatos.API.Infra.Dados
{
    public class CandidatoRepositório : ICandidatoRepositório
    {
        private readonly IMongoCollection<Candidato> _candidatos;

        public CandidatoRepositório(IRankingCandidatosDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _candidatos = database.GetCollection<Candidato>(settings.CandidatosCollectionName);
        }

        public List<Candidato> ListarCandidatos() => _candidatos.Find(c => true).ToList();

        public Candidato CriarCandidato(Candidato candidato)
        {
            _candidatos.InsertOne(candidato);
            return candidato;
        }
    }
}