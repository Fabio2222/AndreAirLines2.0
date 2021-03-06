using System.Collections.Generic;
using AndreAirLines2._0Aeroporto.Utils;
using Models;
using MongoDB.Driver;
using NHibernate.Cfg;
using NuGet.Configuration;

namespace AndreAirLines2._0Aeroporto.Services
{
    public class AeroportoService
    {
        private readonly IMongoCollection<Aeroporto> _aeroportos;

        public AeroportoService(IAeroportoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _aeroportos = database.GetCollection<Aeroporto>(settings.AeroportoCollectionName);
        }

        public List<Aeroporto> Get() =>
            _aeroportos.Find(aeroporto => true).ToList();

        public Aeroporto Get(string id) =>
            _aeroportos.Find<Aeroporto>(aeroporto => aeroporto.Id == id).FirstOrDefault();

        public Aeroporto Create(Aeroporto aeroporto)
        {
            _aeroportos.InsertOne(aeroporto);
            return aeroporto;
        }

        public void Update(string id, Aeroporto aeroportoIn) =>
            _aeroportos.ReplaceOne(cliente => cliente.Id == id, aeroportoIn);

        public void Remove(Aeroporto aeroportoIn) =>
            _aeroportos.DeleteOne(aeroporto => aeroporto.Id == aeroportoIn.Id);

        public void Remove(string id) =>
            _aeroportos.DeleteOne(aeroporto => aeroporto.Id == id);
    }
}

