using LibraryAPI.Models.UserModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts
{
    public class ShowAllBookmarksStoryContext : IRequest<List<Bookmark>>
    {
    }
}
