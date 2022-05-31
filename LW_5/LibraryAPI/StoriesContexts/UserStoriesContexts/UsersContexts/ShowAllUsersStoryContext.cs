using LibraryAPI.Models.UserModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts
{
    public class ShowAllUsersStoryContext : IRequest<List<User>>
    {
    }
}
