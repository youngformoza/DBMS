using MediatR;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts
{
    public class UpdateBookmarkStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string BookmarkNameOfTheCompilation { get; set; }
        public int UserId { get; set; }
    }
}
