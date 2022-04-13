using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Aeronave
    {
        #region Propriedades
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string LoginUser { get; set; }
        #endregion
    }
}
