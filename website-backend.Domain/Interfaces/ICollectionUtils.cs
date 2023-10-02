using MongoDB.Bson;
using MongoDB.Driver;

namespace website_backend.Domain.Interfaces
{
    public interface ICollectionUtils
    {
        void InsertIntoCollection<T>(IMongoCollection<BsonDocument> collection, T objectModel);
    }
}
