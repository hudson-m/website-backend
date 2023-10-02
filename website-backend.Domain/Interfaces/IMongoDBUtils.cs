using MongoDB.Bson;
using MongoDB.Driver;
using website_backend.Domain.Enums.Repository;
using website_backend.Domain.Models.Repository;

namespace website_backend.Domain.Interfaces
{
    public interface IMongoDBUtils
    {
        IMongoDatabase GetDatabase(Databases database);
        IMongoCollection<BsonDocument> ConnectCollection(IMongoDatabase mongoDatabase, string collectionName);
        IMongoCollection<BsonDocument> GetMongoCollection(string database, CollectionsEnum collectionName);
    }
}
