using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Endereco
    {
        #region Propriedades   

        public string Id { get; set; }

        public string Bairro { get; set; }
        public string Cidade { get; set; }
        
        public string Pais { get; set; }
       
        public string CodigoPostal { get; set; }
       
        public string Rua { get; set; }
        public string Estado { get; set; }       
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Continente { get; set; }
        public string UF { get; set; }
        #endregion
    }
}
