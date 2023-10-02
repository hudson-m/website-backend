using website_backend.Domain.Enums.Repository;

namespace website_backend.Domain.Models.Repository
{
    public class Databases
    {
        private string _contentDatabase;


        public string ContentDatabase { get; set; }
        public Databases()
        {
            ContentDatabase = Environment.GetEnvironmentVariable(DatabaseEnum.contentDatabase.ToString());
        }
    }
}
