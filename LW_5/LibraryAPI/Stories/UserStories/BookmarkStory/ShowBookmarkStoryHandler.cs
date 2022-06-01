using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.BookmarkStory
{
    public class ShowBookmarkStoryHandler : IRequestHandler<ShowBookmarkStoryContext, Bookmark>
    {
        private readonly IRepository<DbUserContext> _repository;

        public ShowBookmarkStoryHandler(IRepository<DbUserContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Bookmark> Handle(ShowBookmarkStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<Bookmark>(request.Id);
            return item;
        }
    }
}
