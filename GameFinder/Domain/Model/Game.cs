using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace GameFinder.Domain.Model
{
    public class Game
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("manufacturer")]
        public ObjectId ManufacturerId { get; set; }

        [BsonElement("store")]
        public ObjectId StoreId { get; set; }

        [BsonElement("genres")]
        public List<string> Genres { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }

        [BsonElement("languages")]
        public List<string> Languages { get; set; }

        [BsonElement("count")]
        public int Count { get; set; }

        public Game(
            string name,
            ObjectId manufacturerId,
            ObjectId storeId,
            List<string> genres,
            int year,
            int price,
            List<string> languages,
            int count,
            ObjectId id = new ObjectId()
        )
        {
            Id = id;
            Name = name;
            ManufacturerId = manufacturerId;
            StoreId = storeId;
            Genres = genres;
            Year = year;
            Price = price;
            Languages = languages;
            Count = count;
        }
    }
}
