using MediatR;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts
{
    public class AddBookmarkStoryContext : IRequest<int>
    {
        public string BookmarkNameOfTheCompilation { get; set; }
        public int UserId { get; set; }
    }
}
