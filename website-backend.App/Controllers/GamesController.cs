using MediatR;
using Microsoft.AspNetCore.Mvc;
using website_backend.Domain.Models.Commands.Games.Request;
using website_backend.Domain.Models.Commands.Games.Response;

namespace website_backend.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly IMediator _mediator;
        public GamesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CreateReview")]
        public async Task<CreateReviewResponseCommand> CreateReviewAsync([FromBody] CreateReviewRequestCommand request = null)
        {
            CreateReviewResponseCommand test = await _mediator.Send(request);

            return test;
        }

    }
}
