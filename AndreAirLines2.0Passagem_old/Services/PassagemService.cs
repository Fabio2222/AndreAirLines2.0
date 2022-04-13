/*using System.Collections.Generic;
using AndreAirLines2._0Passagem.Utils;
using Models;
using MongoDB.Driver;

namespace AndreAirLines2._0Passagem.Services
{
   public class PassagemService
   {
       private readonly IMongoCollection<Passagem> _passagens;

       public PassagemService(IPassagemDatabaseSettings settings)
       {
           var client = new MongoClient(settings.ConnectionString);
           var database = client.GetDatabase(settings.DatabaseName);
           _passagens = database.GetCollection<Passagem>(settings.PassagemCollectionName);
       }

       public List<Passagem> Get() =>
           _passagens.Find(passagem => true).ToList();

      public Passagem Get(string id) =>
           _passagens.Find<Passagem>(passagem => passagem.Id == id).FirstOrDefault();

       public Passagem Create(Passagem passagem)
       {
           _passagens.InsertOne(passagem);
           return passagem;
       }

       public void Update(string id, Passagem passagemIn) =>
           _passagens.ReplaceOne(cliente => cliente.Id == id, passagemIn);

       public void Remove(Passagem passagemIn) =>
           _passagens.DeleteOne(passagem => passagem.Id == passagemIn.Id);

       public void Remove(string id) =>
           _passagens.DeleteOne(passagem => passagem.Id == id);

   }
}
*/