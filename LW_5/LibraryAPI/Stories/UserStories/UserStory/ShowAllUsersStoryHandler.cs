using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.UserStory
{
    public class ShowAllUsersStoryHandler : IRequestHandler<ShowAllUsersStoryContext, List<User>>
    {
        private readonly IUserRepository _repository;

        public ShowAllUsersStoryHandler(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<User>> Handle(ShowAllUsersStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<User>();

            return item.ToList();
        }
    }
}
