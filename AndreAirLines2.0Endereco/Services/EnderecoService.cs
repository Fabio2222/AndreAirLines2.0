using System.Collections.Generic;
using AndreAirLines2._0Endereco.Utils;
using Models;
using MongoDB.Driver;

namespace AndreAirLines2._0Endereco.Services
{
    public class EnderecoService
    {
        private readonly IMongoCollection<Endereco> _enderecos;

        public EnderecoService(IEnderecoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _enderecos = database.GetCollection<Endereco>(settings.EnderecoCollectionName);
        }

        public List<Endereco> Get() =>
            _enderecos.Find(endereco => true).ToList();

        public Endereco Get(string id) =>
            _enderecos.Find<Endereco>(endereco => endereco.Id == id).FirstOrDefault();

        public Endereco Create(Endereco endereco)
        {
            _enderecos.InsertOne(endereco);
            return endereco;
        }

        public void Update(string id, Endereco endereco) =>
            _enderecos.ReplaceOne(cliente => cliente.Id == id, enderecoIn);

        public void Remove(Endereco enderecoIn) =>
            _enderecos.DeleteOne(endereco => endereco.Id == enderecoIn.Id);

        public void Remove(string id) =>
            _enderecos.DeleteOne(endereco => endereco.Id == id);
    }
}
    

