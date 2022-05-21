using GameFinder.Domain.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Data.Repository
{
    public class ManufacturerRepository
    {
        private IMongoCollection<Manufacturer> external;

        public ManufacturerRepository(IMongoCollection<Manufacturer> collection)
        {
            external = collection;
        }

        public List<Manufacturer> GetAll() => external.Find(new BsonDocument()).ToList();

        public Manufacturer GetById(ObjectId id)
        {
            var filter = Builders<Manufacturer>.Filter.Where(m => m.Id == id);
            return external.Find(filter).Single();
        }

        public Manufacturer GetByName(string name)
        {
            var filter = Builders<Manufacturer>.Filter.Where(m => m.Name == name);
            return external.Find(filter).Single();
        }

        public void Insert(Manufacturer manufacturer) => external.InsertOne(manufacturer);

        public void DeleteById(ObjectId id) =>
            external.DeleteOne(manufacturer => manufacturer.Id == id);

        public void FillWithDefault()
        {
            Insert(new Manufacturer(
                name: "Ubisoft",
                country: "France",
                website: "ubisoft.com",
                id: new ObjectId("000000000000000000000001")
            ));
            Insert(new Manufacturer(
                name: "Electronic Arts",
                country: "USA",
                website: "ea.com",
                id: new ObjectId("000000000000000000000002")
            ));
            Insert(new Manufacturer(
                name: "CD Projekt RED",
                country: "Poland",
                website: "cdprojekt.com",
                id: new ObjectId("000000000000000000000003")
            ));
            Insert(new Manufacturer(
                name: "Valve",
                country: "USA",
                website: "valvesoftware.com",
                id: new ObjectId("000000000000000000000004")
            ));
        }
    }
}
