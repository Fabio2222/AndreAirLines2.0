using System.Collections.Generic;
using AndreAirLinesAPI2._0Aeronave.Utils;
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
            _aeronaves.Find<Aeronave>(aeronave => aeronave.Id == id).FirstOrDefault();

        public Aeronave Create(Aeronave aeronave)
        {
            _aeronaves.InsertOne(aeronave);
            return aeronave;
        }

        public void Update(string id, Aeronave aeronaveIn) =>
            _aeronaves.ReplaceOne(aeronave => aeronave.Id == id, aeronaveIn);

        public void Remove(Aeronave aeronaveIn) =>
            _aeronaves.DeleteOne(aeronave => aeronave.Id == aeronaveIn.Id);

        public void Remove(string id) =>
            _aeronaves.DeleteOne(aeronave => aeronave.Id == id);
    }
}