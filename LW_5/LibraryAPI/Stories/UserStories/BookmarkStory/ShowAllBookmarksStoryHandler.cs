using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.BookmarkStory
{
    public class ShowAllBookmarksStoryHandler : IRequestHandler<ShowAllBookmarksStoryContext, List<Bookmark>>
    {
        private readonly IUserRepository _repository;

        public ShowAllBookmarksStoryHandler(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<Bookmark>> Handle(ShowAllBookmarksStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<Bookmark>();

            return item.ToList();
        }
    }
}
