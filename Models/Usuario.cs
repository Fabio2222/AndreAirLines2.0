using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Models
{
    public class Usuario : Pessoa
    {
        #region Propriedades
        /*[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]*/
        public string Senha { get; set; }
        public string Login { get; set; }
        public string Role { get; set; } //[authorize(Role = )
        public string Funcao { get; set; }
        #endregion

    }
}
