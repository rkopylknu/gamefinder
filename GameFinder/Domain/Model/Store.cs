using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GameFinder.Domain.Model
{
    public class Store
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        public Store(string name, string address, ObjectId id = new ObjectId())
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
