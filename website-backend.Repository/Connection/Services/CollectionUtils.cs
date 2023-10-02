using MongoDB.Bson;
using MongoDB.Driver;
using website_backend.Domain.Interfaces;

namespace website_backend.Repository.Connection.Services
{
    public class CollectionUtils : ICollectionUtils
    {
        public void InsertIntoCollection<T>(IMongoCollection<BsonDocument> collection, T objectModel)
        {
            BsonDocument bsonObject = objectModel.ToBsonDocument();

            try
            {
                collection.InsertOne(bsonObject);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
