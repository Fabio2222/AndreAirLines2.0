using System.Collections.Generic;
using AndreAirLinesAPI2._0Aeronave.Utils;
using AndreAirLinesAPI2._0Usuario.Utils;
using Models;
using MongoDB.Driver;


namespace AndreAirLinesAPI2._0Aeronave.Services
{
    public class AeronaveService
    {
        private readonly IMongoCollection<Aeronave> _aeronaves;

        public AeronaveService(IAeronaveDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _aeronaves = database.GetCollection<Aeronave>(settings.AeronaveCollectionName);
        }

        public List<Aeronave> Get() =>
            _aeronaves.Find(cliente => true).ToList();

        public Aeronave Get(string id) =>
            _aeronaves.Find<Aeronave>(cliente => cliente.Id == id).FirstOrDefault();

        public Aeronave Create(Aeronave cliente)
        {
            _aeronaves.InsertOne(cliente);
            return cliente;
        }

        public void Update(string id, Aeronave clienteIn) =>
            _aeronaves.ReplaceOne(cliente => cliente.Id == id, clienteIn);

        public void Remove(Aeronave clienteIn) =>
            _aeronaves.DeleteOne(cliente => cliente.Id == clienteIn.Id);

        public void Remove(string id) =>
            _aeronaves.DeleteOne(cliente => cliente.Id == id);
    }
}