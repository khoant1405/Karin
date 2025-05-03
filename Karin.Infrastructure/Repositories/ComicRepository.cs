using Karin.Domain.Entities;
using MongoDB.Driver;

namespace Karin.Infrastructure.Repositories
{
    public class ComicRepository : BaseRepository<Comic>
    {
        public ComicRepository(IMongoDatabase db) : base(db, "Comics")
        {
        }
    }
}