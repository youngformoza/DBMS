using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class DeleteSectionStoryHandler : IRequestHandler<DeleteSectionStoryContext, bool>
    {
        private readonly IRepository<DbLibraryContext> _repository;

        public DeleteSectionStoryHandler(IRepository<DbLibraryContext> repository)
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
