using website_backend.Domain.Models.Request;

namespace website_backend.Domain.Interfaces
{
    public interface IGamesService
    {
        void PostReview(PostReviewRequest request);
    }
}
