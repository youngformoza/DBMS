using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace LibraryAPI.Controllers.UserControllers
{
    [Route("api/[controller]")]
[ApiController]
    public class BookmarksController
    {
        private readonly IMediator _mediator;

        public BookmarksController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
    }
}
