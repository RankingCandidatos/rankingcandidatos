using MongoDB.Bson.Serialization.Attributes;

namespace rankingcandidatos.API.Dominio
{
    public class Candidato
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nome { get; set; }

        public int Número { get; set; }
    }
}
