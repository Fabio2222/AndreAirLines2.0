using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Passagem
    {
        #region
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Voo Voo { get; set; }
        public Passageiro Passageiro { get; set; }
        public PrecoBase PrecoBase { get; set; }
        public Classe Classe { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PromocaoPorcentagem { get; set; }
        public string LoginUser { get; set; }
        #endregion
    }
}