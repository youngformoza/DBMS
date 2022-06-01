using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.UserStory
{
    public class ShowUserStoryHandler : IRequestHandler<ShowUserStoryContext, User>
    {
        private readonly IRepository<DbUserContext> _repository;

        public ShowUserStoryHandler(IRepository<DbUserContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<User> Handle(ShowUserStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<User>(request.Id);
            return item;
        }
    }
}
