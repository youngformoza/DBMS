using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class ShowSectionStoryHandler : IRequestHandler<ShowSectionStoryContext, Section>
    {
        private readonly ILibraryRepository _repository;

        public ShowSectionStoryHandler(ILibraryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Section> Handle(ShowSectionStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<Section>(request.Id);
            return item;
        }
    }
}
