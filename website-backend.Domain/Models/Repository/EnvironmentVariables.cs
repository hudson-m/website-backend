using website_backend.Domain.Enums.Repository;

namespace website_backend.Domain.Models.Repository
{
    public class EnvironmentVariables
    {
        private string _mongoDBUser;
        private string _mongoDBMainCluster;

        public EnvironmentVariables()
        {
            MongoDBUser = Environment.GetEnvironmentVariable(EnvironmentVariablesEnum.mongoDBUser.ToString());
            MongoDBMainCluster = Environment.GetEnvironmentVariable(EnvironmentVariablesEnum.mongoDBMainCluster.ToString());
        }

        public string MongoDBUser { get; set; }
        public string MongoDBMainCluster { get; set; }
    }
}
