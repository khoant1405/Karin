using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Karin.Domain.Entities
{
    public class Chapter : IEntity
    {
        [BsonElement("comicId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ComicId { get; set; }

        [BsonElement("chapterNumber")]
        public int ChapterNumber { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("views")]
        public long Views { get; set; }

        [BsonElement("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}