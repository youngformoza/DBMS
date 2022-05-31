using MediatR;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts
{
    public class AddUserStoryContext : IRequest<int>
    {
        public string UserNickname { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int RoleId { get; set; }
    }
}
