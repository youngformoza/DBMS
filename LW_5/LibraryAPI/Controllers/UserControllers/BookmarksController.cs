using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Http;
using LibraryAPI.Models.UserModels;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;

namespace LibraryAPI.Controllers.UserControllers
{
    [Route("api/[controller]")]
[ApiController]
    public class BookmarksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookmarksController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] AddBookmarkStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok(response);
        }

        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Bookmark))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] ShowBookmarkStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Bookmark>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetList(CancellationToken token)
        {
            var story = new ShowAllBookmarksStoryContext();
            var response = await _mediator.Send(story, token);

            if (response.Count == 0)
            {
                return NotFound("Объекты не найдены");
            }

            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put([FromBody] UpdateBookmarkStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] DeleteBookmarkStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return NoContent();
        }
    }
}
