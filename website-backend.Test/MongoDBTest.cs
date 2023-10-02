using MongoDB.Bson;
using MongoDB.Driver;

namespace Test
{
    public class MongoDBTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConnectDatabase()
        {
            string databaseUser = Environment.GetEnvironmentVariable("mongoDBUser");
            string databaseCluster = Environment.GetEnvironmentVariable("mongoDBMainCluster");

            string connectionUri = $"mongodb+srv://{databaseUser}@{databaseCluster}/?retryWrites=true&w=majority&appName=AtlasApp";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("ContentDb").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}