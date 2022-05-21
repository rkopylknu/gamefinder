using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GameFinder.Domain.Model
{
    public class Manufacturer
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        [BsonElement("website")]
        public string Website { get; set; }

        public Manufacturer(string name, string country, string website, ObjectId id = new ObjectId())
        {
            Id = id;
            Name = name;
            Country = country;
            Website = website;
        }
    }
}
