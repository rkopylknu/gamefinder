using GameFinder.Domain.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Data.Repository
{
    public class StoreRepository
    {
        private IMongoCollection<Store> external;

        public StoreRepository(IMongoCollection<Store> collection)
        {
            external = collection;
        }

        public List<Store> GetAll() => external.Find(new BsonDocument()).ToList();

        public Store GetById(ObjectId id)
        {
            var filter = Builders<Store>.Filter.Where(s => s.Id == id);
            return external.Find(filter).Single();
        }

        public Store GetByName(string name)
        {
            var filter = Builders<Store>.Filter.Where(s => s.Name == name);
            return external.Find(filter).Single();
        }

        public void Insert(Store store) => external.InsertOne(store);

        public void DeleteById(ObjectId id) => external.DeleteOne(s => s.Id == id);

        public void FillWithDefault()
        {
            Insert(new Store(
                name: "TrueGames",
                address: "Example street, 10",
                id: new ObjectId("000000000000000000000001")
            ));
            Insert(new Store(
                name: "Digitalize",
                address: "Default street, 5",
                id: new ObjectId("000000000000000000000002")
            ));
        }
    }
}
