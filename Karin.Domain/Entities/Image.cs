using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Karin.Domain.Entities
{
    public class Image : IEntity
    {
        [BsonElement("chapterId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ChapterId { get; set; }

        [BsonElement("imageUrl")]
        public string ImageUrl { get; set; }

        [BsonElement("order")]
        public int Order { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}