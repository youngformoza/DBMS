using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class DeleteSectionStoryHandler : IRequestHandler<DeleteSectionStoryContext, bool>
    {
        private readonly ILibraryRepository _repository;

        public DeleteSectionStoryHandler(ILibraryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteSectionStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<Section>(request.Id);
            return deleted;
        }
    }
}
