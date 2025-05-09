using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Karin.Domain.Entities
{
    public class Genre : IEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}