using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Karin.Domain.Entities
{
    public class Comic : IEntity
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }

        [BsonElement("coverImage")]
        public string CoverImage { get; set; }

        [BsonElement("genres")]
        public List<string> Genres { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("views")]
        public long Views { get; set; }

        [BsonElement("rating")]
        public double Rating { get; set; }

        [BsonElement("ratingCount")]
        public long RatingCount { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}