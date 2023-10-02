using MediatR;
using website_backend.Domain.Interfaces;
using website_backend.Domain.Models.Commands.Games.Request;
using website_backend.Domain.Models.Commands.Games.Response;
using website_backend.Infra.Models;

namespace website_backend.Domain.Handlers.Games
{
    public class CreateReviewHandler : IRequestHandler<CreateReviewRequestCommand, CreateReviewResponseCommand>
    {
        private readonly IGamesService _gameservice;

        public CreateReviewHandler(IGamesService gameservice)
        {
            _gameservice = gameservice;
        }

        public Task<CreateReviewResponseCommand> Handle(CreateReviewRequestCommand request, CancellationToken cancellationToken)
        {
            CreateReviewResponseCommand response = new CreateReviewResponseCommand();
            _gameservice.PostReview(request.PostReview);


            return Task.FromResult(response);
        }
    }
}
