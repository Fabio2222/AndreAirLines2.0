using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class DataAeroporto
    {
        #region
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Codigo { get; set; }
        public string Pais { get; set; }
        public string Continente { get; set; }
        #endregion
    }
}
