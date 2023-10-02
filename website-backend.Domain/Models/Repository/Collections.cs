using website_backend.Domain.Enums.Repository;

namespace website_backend.Domain.Models.Repository
{
    public class Collections
    {
        private string _reviewCollection;

        public string ContentDatabase
        {
            get
            {
                return _reviewCollection;
            }
            set
            {
                _reviewCollection = DatabaseEnum.contentDatabase.ToString();
            }
        }
    }
}
