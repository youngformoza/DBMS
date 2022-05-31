using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Http;
using LibraryAPI.StoriesContexts.BooksContexts;
using LibraryAPI.Models.BookModels;

namespace LibraryAPI.Controllers.LibraryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] AddBookStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok(response);
        }

        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] ShowBookStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetList(CancellationToken token)
        {
            var story = new ShowAllBooksStoryContext();
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
        public async Task<IActionResult> Put([FromBody] UpdateBookStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] DeleteBookStoryContext storyContext, CancellationToken token)
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
