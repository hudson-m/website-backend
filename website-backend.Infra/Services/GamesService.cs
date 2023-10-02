using MongoDB.Bson;
using MongoDB.Driver;
using website_backend.Domain.Enums.Repository;
using website_backend.Domain.Interfaces;
using website_backend.Domain.Models.Request;

namespace website_backend.Infra.Services
{
    public class GamesService : IGamesService
    {
        private readonly IMongoDBUtils _mongoDB;
        private readonly ICollectionUtils _collectionUtils;
        public GamesService(IMongoDBUtils mongoDB, ICollectionUtils collectionUtils)
        {
            _mongoDB = mongoDB;
            _collectionUtils = collectionUtils;
        }

        public void PostReview(PostReviewRequest request)
        {
            IMongoCollection<BsonDocument> collection = _mongoDB.GetMongoCollection(request.DataAccess, CollectionsEnum.Reviews);

            _collectionUtils.InsertIntoCollection(collection, request.Review);
        }
    }
}
