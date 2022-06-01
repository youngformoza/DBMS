using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.BookmarkStory
{
    public class DeleteBookmarkStoryHandler : IRequestHandler<DeleteBookmarkStoryContext, bool>
    {
        private readonly IRepository<DbUserContext> _repository;

        public DeleteBookmarkStoryHandler(IRepository<DbUserContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteBookmarkStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<Bookmark>(request.Id);
            return deleted;
        }
    }
}
