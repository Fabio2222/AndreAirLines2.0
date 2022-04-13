using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Aeroporto
    {
        #region Propriedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Iatacode { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string LoginUser { get; set; }
        #endregion

}
}
