using rankingcandidatos.API.Dominio;

namespace rankingcandidatos.API.Infra.Dados
{
    public class RankingCandidatosDatabaseSettings : IRankingCandidatosDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string CandidatosCollectionName { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRankingCandidatosDatabaseSettings
    {
        string ConnectionString { get; set; }
        string CandidatosCollectionName { get; set; }
        string DatabaseName { get; set; }
    }
}
