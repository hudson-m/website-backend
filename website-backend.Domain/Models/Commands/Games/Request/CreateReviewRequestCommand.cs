using MediatR;
using System.Text.Json.Serialization;
using website_backend.Domain.Models.Commands.Games.Response;
using website_backend.Domain.Models.Request;

namespace website_backend.Domain.Models.Commands.Games.Request
{
    public class CreateReviewRequestCommand : IRequest<CreateReviewResponseCommand>
    {
        public CreateReviewRequestCommand()
        {
            PostReview = new PostReviewRequest();
        }

        public PostReviewRequest PostReview { get; internal set; }
    }
}
