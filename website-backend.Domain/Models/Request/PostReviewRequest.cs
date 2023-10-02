using website_backend.Domain.Enums.Repository;
using website_backend.Infra.Models;

namespace website_backend.Domain.Models.Request
{
    public class PostReviewRequest
    {
        private string _dataAccess;

        public PostReviewRequest()
        {
            DataAccess = Environment.GetEnvironmentVariable(DatabaseEnum.contentDatabase.ToString());
            Review = new ReviewModel();
        }

        public string DataAccess { get; set; }
        public ReviewModel Review { get; set; }
    }
}
