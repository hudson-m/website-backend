using MongoDB.Bson;
using MongoDB.Driver;
using website_backend.Domain.Enums.Repository;
using website_backend.Domain.Interfaces;
using website_backend.Domain.Models.Repository;

namespace website_backend.Repository.Connection.Services
{
    public class MongoDBUtils : IMongoDBUtils
    {
        public MongoDBUtils()
        {
        }

        public IMongoDatabase GetDatabase(Databases database)
        {
            EnvironmentVariables envVariables = new EnvironmentVariables();
            string databaseUser = envVariables.MongoDBUser;
            string databaseCluster = envVariables.MongoDBMainCluster;

            string connectionUri = $"mongodb+srv://{databaseUser}@{databaseCluster}/?retryWrites=true&w=majority&appName=AtlasApp";
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            MongoClient client = new MongoClient(settings);

            try
            {
                IMongoDatabase result = client.GetDatabase(database.ContentDatabase);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IMongoCollection<BsonDocument> ConnectCollection(IMongoDatabase mongoDatabase, string collectionName)
        {
            IMongoCollection<BsonDocument> collection = mongoDatabase.GetCollection<BsonDocument>(collectionName);

            return collection;
        }

        public IMongoCollection<BsonDocument> GetMongoCollection(string database, CollectionsEnum collectionName)
        {
            EnvironmentVariables envVariables = new EnvironmentVariables();
            string databaseUser = envVariables.MongoDBUser;
            string databaseCluster = envVariables.MongoDBMainCluster;

            string connectionUri = $"mongodb+srv://{databaseUser}@{databaseCluster}/?retryWrites=true&w=majority&appName=AtlasApp";
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            MongoClient client = new MongoClient(settings);

            try
            {
                IMongoDatabase result = client.GetDatabase(database);

                IMongoCollection<BsonDocument> collection = result.GetCollection<BsonDocument>(collectionName.ToString());

                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
