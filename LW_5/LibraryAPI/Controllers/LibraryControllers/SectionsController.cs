using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Http;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using LibraryAPI.Models.BookModels;

namespace LibraryAPI.Controllers.LibraryControllers
{
    [Route("api/[controller]")]
[ApiController]
    public class SectionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SectionsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] AddSectionStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok(response);
        }

        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Section))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] ShowSectionStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Section>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetList(CancellationToken token)
        {
            var story = new ShowAllSectionsStoryContext();
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
        public async Task<IActionResult> Put([FromBody] UpdateSectionStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] DeleteSectionStoryContext storyContext, CancellationToken token)
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
